using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;
namespace Web.APP.Controllers
{
    public class KetoanController : BaseController
    {
        int PageSize =int.Parse( ConfigurationManager.AppSettings["PageSize"].ToString());
        // GET: Ketoan
        public ActionResult Index()
        {
            //if (Session["User_DN"] == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
            return View();
        }
        
        public ActionResult TaikhoanSodu(string NamTC)
        {
            //if (Session["User_DN"] == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
            if (NamTC == null)
                NamTC = Session["NamTC"].ToString();
            DN_BL_BangTK _BangTK = new DN_BL_BangTK();
            List<DN_Entity_BangTK> Obj = _BangTK.GetBangTK(Int16.Parse( NamTC) , 1, PageSize);
            ViewBag.TongNo = _BangTK.GetTongDuNo(Int16.Parse(NamTC));
            ViewBag.TongCo = _BangTK.GetTongDuNo(Int16.Parse(NamTC));
            return View(Obj);
        }

    }
}