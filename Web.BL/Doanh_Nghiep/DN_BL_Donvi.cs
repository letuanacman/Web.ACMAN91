using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.DL; 

namespace Web.BL
{
   public class DN_BL_Donvi
    {
        public DN_Entity_Donvi Get_Donvi()
        {
            DN_Entity_Donvi Dv = new DN_Entity_Donvi();
            DN_DL_Donvi DL = new DN_DL_Donvi();
            Dv = DL.GetDonvi();
            return Dv;
        }

    }
}
