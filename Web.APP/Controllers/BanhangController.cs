using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;
using System.Configuration;
using PagedList;
using PagedList.Mvc;
namespace Web.APP.Controllers
{
   
    public class BanhangController : BaseController
    {
       private static int PageSize = int.Parse(ConfigurationManager.AppSettings["PageSize"].ToString());
        // GET: Banhang
        public ActionResult Index()
        {
            //if (Session["User_DN"] == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
            return View();
        }
        
        public ActionResult Quanlydonhang(string NamTC, int page=1)
        {
            //if (Session["User_DN"] == null)
            //{
            //    return RedirectToAction("Index", "Login");
            //}
            if (NamTC == null)
                NamTC = Session["NamTC"].ToString();
            
            DN_BL_QLBanHang _BangTK = new DN_BL_QLBanHang();
            IEnumerable<DN_Entity_ShopBanHang> Obj = _BangTK.GetHoadonBanHang(Int16.Parse(NamTC),   0).OrderByDescending(m=>m.SO_DONHANG).ToPagedList(page, PageSize) ; 
            return View(Obj);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DN_Entity_ShopBanHang qlbanhang)
        {
            return View();
        }
    }
}