using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;
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
        public ActionResult ViewTaikhoanSodu()
        {
            if (Session["User_DN"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            DN_BL_BangTK _BangTK = new DN_BL_BangTK();
            List<DN_Entity_BangTK> Obj = _BangTK.GetBangTK(2020, 1, 10);
            return View(Obj);
        }

    }
}