using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;

namespace Web.APP.Controllers
{
    public class BanhangController : Controller
    {
        // GET: Banhang
        public ActionResult Index()
        {
            if (Session["User_DN"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        
        public ActionResult Quanlydonhang(string NamTC)
        {
            if (Session["User_DN"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            if (NamTC == null)
                NamTC = Session["NamTC"].ToString();
            DN_BL_QLBanHang _BangTK = new DN_BL_QLBanHang();
            List<DN_Entity_ShopBanHang> Obj = _BangTK.GetHoadonBanHang(Int16.Parse(NamTC), 1, 10,0); 
            return View(Obj);
        }
    }
}