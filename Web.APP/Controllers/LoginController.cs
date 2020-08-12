using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;
using Web.APP.Models;
using Web.APP.Extentions;

namespace Web.APP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login "060_ECONNECT_0106208713"
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Master_BL_LoginData _BL_LoginData = new Master_BL_LoginData();
                    var Chuoi = _BL_LoginData.GetData_DoanhNghiep(model.TEN_DATA);
                    if (Chuoi != "")
                    {
                        Login_Info _Info = new Login_Info()
                        {
                            Chuoi_KetNoi = Chuoi,
                            UserName = model.TEN_DANGNHAP
                        };

                        Session["Login_Info"] = SecurityExtention.GetPackageServiceJson(_Info);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Sai thông tin");
                    }

                }
                catch (Exception e)
                {
                    throw;
                }
            }
            else
            {
                ModelState.AddModelError("", "Bạn chưa nhập thông tin");
            }
            return View(model);
        }
    }
}