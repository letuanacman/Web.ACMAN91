using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using Web.DL;
using Web.Entities;

namespace Web.BL 
{
    public class DN_BL_Login
    {
        public DN_Entity_UserList KiemTraDangNhap(string UserName, string Pass, string ConnStr)
        {
            DN_Entity_UserList Userlist = new DN_Entity_UserList();
            DN_DL_Login DL = new DN_DL_Login();
            Userlist = DL.ValidLogIn(UserName, Pass, ConnStr);
            return Userlist;
        }
    }
}
