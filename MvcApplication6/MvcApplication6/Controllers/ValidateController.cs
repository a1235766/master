using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
   


    public class ValidateController : Controller
    {
        public JsonResult CheckUserName(string userName)
        {
          
            bool isValidate = false;
            if (userName.ToUpper().IndexOf("SKILLTREE") == -1 &&
                userName.ToUpper().IndexOf("DEMO") == -1 &&
                userName.ToUpper().IndexOf("TWMVC") == -1)
            {
                isValidate = true;
            }

            // Remote 驗證是使用 Get 因此要開放
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }


}