using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Web.APP.Models;

namespace Web.APP.Extentions
{
    public class SecurityExtention
    {
        public static Login_Info GetPackageService(string stringObject)
        {
            return new JavaScriptSerializer().Deserialize<Login_Info>(stringObject);
        }

        public static string GetPackageServiceJson(Login_Info obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}