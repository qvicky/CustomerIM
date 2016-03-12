using CustomerIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerIM.Controllers {
    public class ValidateEmailController : Controller {
        public JsonResult CheckIsDuplate(string Email, int 客戶Id, int Id) {
            bool isValidate = true;
            客戶資料Entities db = new 客戶資料Entities();

            客戶聯絡人 hasSameMoblie = null;
            if (Id != null) {
                hasSameMoblie = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email && p.Id != Id).FirstOrDefault();
            }
            else {
                hasSameMoblie = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email).FirstOrDefault();
            }

            if (hasSameMoblie != null)
                isValidate = false;
            else
                isValidate = true;

            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CheckEmail(string Email, int 客戶Id, int Id) {
            bool isValidate = true;
            客戶資料Entities db = new 客戶資料Entities();

            客戶聯絡人 hasSameMoblie = null;
            if (Id != null) {
                hasSameMoblie = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email && p.Id != Id).FirstOrDefault();
            }
            else {
                hasSameMoblie = db.客戶聯絡人.Where(p => p.客戶Id == 客戶Id && p.Email == Email).FirstOrDefault();
            }

            if (hasSameMoblie != null)
                isValidate = false;
            else
                isValidate = true;

            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }

    }
}