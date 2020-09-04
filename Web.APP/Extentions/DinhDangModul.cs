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
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy");
        }

        public static string FormatTime(DateTime date)
        {
            return date.ToString("HH:mm:ss");
        }


        public static string FormatDateTime(DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm");
        }

        public static string FormatDateTimeAMPM(DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm tt").Replace("SA", "AM").Replace("CH", "PM");
        }

    }
}