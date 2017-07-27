using MvcApplication6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Format()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Format(FormatViewModel data)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View(data);
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult login()
        {
           if (ModelState.IsValid)
            {
                return View();
            }
          
            return Content("登入成功");
        }


    

        [HttpPost]
        //[ValidateInput(false)]
        public ActionResult index(FormatViewModel data)
        {

            if (ModelState.IsValid)
            {
                return Content("登入成功");
              
            }

            return View();

         
        }



    }
}