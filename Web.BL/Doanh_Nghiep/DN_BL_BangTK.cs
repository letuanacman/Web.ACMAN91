using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.DL;

namespace Web.BL
{
   public class DN_BL_BangTK
    {
        public List<DN_Entity_BangTK> GetBangTK(int NamTC, int PageIndex, int PageSize)
        {
             DN_DL_BangTK DL = new DN_DL_BangTK();
            return DL.GetBangTK(NamTC,PageIndex,PageSize); ;
        }

        public double GetTongDuNo(int NamTC)
        {
            DN_DL_BangTK DL = new DN_DL_BangTK();
            return DL.GetTongDuNoCo(NamTC,true); ;
        }
        public double GetTongDuCo(int NamTC)
        {
            DN_DL_BangTK DL = new DN_DL_BangTK();
            return DL.GetTongDuNoCo(NamTC, false); ;
        }
   
    }
}
