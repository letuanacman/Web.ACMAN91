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
                        Session["DN_ConnectString"] = Chuoi;
                        DN_BL_Login _BL_Login = new DN_BL_Login();
                        DN_Entity_UserList _Login = new DN_Entity_UserList();
                        _Login = _BL_Login.KiemTraDangNhap(model.TEN_DANGNHAP, SecurityExtention.MaHoaMD5(model.MAT_KHAU), Chuoi);
                        if (_Login.USERNAME != null)
                        {
                            Session["User_DN"] = new LoginInfoModel()
                            { U_ID = _Login.U_ID, TEN_DANGNHAP = _Login.USERNAME, FULLNAME = _Login.FULLNAME, TEN_DATA = model.TEN_DATA };
                            DN_BL_Donvi _BL_Donvi = new DN_BL_Donvi();
                            DN_Entity_Donvi dv = new DN_Entity_Donvi();
                            dv = _BL_Donvi.Get_Donvi();
                            Session["Donvi_Info"] = new DonviInfoModel()
                            {
                                Ma_so = dv.Ma_so,
                                Ten_dv = dv.Ten_dv,
                                Ten_dv_English = dv.Ten_dv_English,
                                Giamdoc = dv.Giamdoc,
                                dia_chi = dv.dia_chi,
                                Nam_tc = dv.Nam_tc,
                                QHuyen = dv.QHuyen,
                                City = dv.City,
                                TK = dv.TK,
                                NHang = dv.NHang,
                                Tel = dv.Tel,
                                Email = dv.Email
                            };
                            Session["NamTC"] = dv.Nam_tc;
                            return RedirectToAction("Index", "Banhang");
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
                catch (Exception)
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
            return RedirectToAction("Index", "Home");
        }
    }
}