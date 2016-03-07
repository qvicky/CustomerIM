﻿using System;
namespace CustomerIM.Models {
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料 {
    }

    public class 客戶資料MetaData {
        public int Id { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 客戶名稱 { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(8, ErrorMessage = "欄位長度不得大於 8 個字元")]
        public string 統一編號 { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 電話 { get; set; }
        [StringLength(50, ErrorMessage = "欄位長度不得大於 50 個字元")]
        public string 傳真 { get; set; }
        [StringLength(100, ErrorMessage = "欄位長度不得大於 100 個字元")]
        public string 地址 { get; set; }
        [EmailAddress(ErrorMessage="郵件格式有誤")]
        [StringLength(250, ErrorMessage = "欄位長度不得大於 250 個字元")]
        public string Email { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }



}