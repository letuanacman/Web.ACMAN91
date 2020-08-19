using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.APP.Controllers
{
    public class KetoanController : Controller
    {
        // GET: Ketoan
        public ActionResult Index()
        {
            if (Session["User_DN"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}