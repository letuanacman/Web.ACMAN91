using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.APP.Extentions
{
    public class DinhDangModul
    {
        public static string GetDinhDangGiaTien(double giaTri)
        {
            return giaTri <= 0.0 ? "0" : string.Format("{0:0,0}", (object)Convert.ToDouble(Convert.ToDouble(giaTri).ToString())).Replace(",", ".");
        }
    }
}