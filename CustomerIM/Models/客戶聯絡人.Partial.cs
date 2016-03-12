namespace CustomerIM.Models {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Web.Mvc;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject {
        //驗證Email不可重覆 Model Validate
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            var db = new 客戶資料Entities();

            if (this.Id == 0) {
                //create
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id &&  p.Email == this.Email).Any()) {
                    yield return new ValidationResult("Email 重覆");
                }
            }
            else {
                //update
                if (db.客戶聯絡人.Where(p => p.客戶Id == this.客戶Id && p.Email == this.Email && p.Id != this.Id).Any()) {
                    yield return new ValidationResult("Email 重覆");
                }
            }
            yield return ValidationResult.Success;
        }
    }

    public class 客戶聯絡人MetaData : IValidatableObject {
        public int Id { get; set; }
        public int 客戶Id { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 職稱 { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 姓名 { get; set; }

        [Required(ErrorMessage = "必填欄位")]
        [StringLength(250, ErrorMessage = "欄位長度不得大於 250 個字元")]
        [EmailAddress(ErrorMessage = "郵件格式有誤")]
        public string Email { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        //[自訂手機驗證(ErrorMessage = "格式錯誤，應為 0911-123456")]
        [RegularExpression(@"\d{4}-\d{6}",ErrorMessage="手機格式應為 09xx-xxxx")]
        public string 手機 { get; set; }

        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }

        public Nullable<bool> IsDeleted { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
            客戶資料Entities db = new 客戶資料Entities();
            //同一個客戶下的聯絡人，其 Email 不能重複
            if (Email != "") {
                客戶聯絡人 hasSameMoblie = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email).FirstOrDefault();
                if (hasSameMoblie != null) {
                    yield return new ValidationResult("連絡人郵件不可以重覆", new[] { "Email" });
                }
            }
        }

    }


}