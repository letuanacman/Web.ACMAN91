using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BL;
using Web.Entities;
using Web.APP.Models;
using Web.APP.Extentions;
using Web.Entities.Doanh_Nghiep;

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
                        Session["DN_ConnectString"] = Chuoi;
                        DN_BL_Login _BL_Login = new DN_BL_Login();
                        DN_Entity_UserList _Login = new DN_Entity_UserList();
                        _Login = _BL_Login.KiemTraDangNhap(model.TEN_DANGNHAP, SecurityExtention.MaHoaMD5(model.MAT_KHAU), Chuoi);
                        if (_Login.USERNAME != null)
                        {
                            Session["User_DN"] = new Login_Info()
                            { U_ID = _Login.U_ID, TEN_DANGNHAP = _Login.USERNAME, FULLNAME = _Login.FULLNAME, TEN_DATA = model.TEN_DATA };

                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Sai thông tin Đăng nhập & Mật khẩu");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Sai thông tin Đăng nhập");
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
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home" ); 
        }
    }
}