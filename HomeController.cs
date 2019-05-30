using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult About(HttpPostedFileBase upload,string text)
        {
            upload.SaveAs(Server.MapPath("~/images/name.jpg"));
            var obj = new { uploaded = 1, fileName = "pep", url = "/images/name.jpg" };
            return Json(obj,JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}