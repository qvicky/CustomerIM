namespace CustomerIM.Models {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊 {
    }
    public class 客戶銀行資訊MetaData {
        public int Id { get; set; }
        public int 客戶Id { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 銀行名稱 { get; set; }
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public int 銀行代碼 { get; set; }
        public Nullable<int> 分行代碼 { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 帳戶名稱 { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(20, ErrorMessage = "欄位長度不得大於 20 個字元")]
        public string 帳戶號碼 { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public virtual 客戶資料 客戶資料 { get; set; }
    }

}