using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.DL;

namespace Web.BL
{
    public class DN_BL_QLBanHang
    {
        public List<DN_Entity_ShopBanHang> GetHoadonBanHang(int NamTC, int PageIndex, int PageSize,int Loai)
        {
            DN_DL_QLBanHang DL = new DN_DL_QLBanHang();
            return DL.GetHoadonBanHang(NamTC, PageIndex, PageSize,Loai); ;
        }
    }
}
