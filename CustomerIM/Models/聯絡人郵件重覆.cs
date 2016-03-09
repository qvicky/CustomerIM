using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CustomerIM.Models {
    public class 聯絡人郵件重覆Attribute : DataTypeAttribute {
        public 聯絡人郵件重覆Attribute() :base(DataType.Text) {
        }

        public override bool IsValid(object value) {
            bool IsDuplicate = true;
            客戶資料Entities db = new 客戶資料Entities();
            string sEmail = (string)value;

            if (!string.IsNullOrEmpty(sEmail)) {

            }

            return IsDuplicate;
        }


    }
}
