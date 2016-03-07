namespace CustomerIM.Models {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 {
    }

    public class 客戶聯絡人MetaData {
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
        [自訂手機驗證(ErrorMessage = "格式錯誤，應為 0911-123456")]
        public string 手機 { get; set; }
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }

}