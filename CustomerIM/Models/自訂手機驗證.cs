using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CustomerIM.Models {
    public class 自訂手機驗證Attribute : DataTypeAttribute {
        public 自訂手機驗證Attribute() : base(DataType.Text) {
        }
        public override bool IsValid(object value) {
            bool IsMatch = true;
            Regex regMobile = new Regex(@"\d{4}-\d{6}");  //手機驗證規
            string sMobile = value != null ? (string)value : "";
            if (sMobile != "")
                IsMatch = regMobile.Match(sMobile).Success;

            return IsMatch;
        }

    }
}
