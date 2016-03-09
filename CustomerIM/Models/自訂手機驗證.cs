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
            if (value == null)
                return true;

            Regex regMobile = new Regex(@"\d{4}-\d{6}");  //手機驗證規
            if (value is string)
                return regMobile.Match(value.ToString()).Success;
            else
                return true;
        }

    }
}
