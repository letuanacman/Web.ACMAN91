using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using Web.APP.Models;

namespace Web.APP.Extentions
{
    public class SecurityExtention
    {
        public static LoginInfoModel GetPackageService(string stringObject)
        {
            return new JavaScriptSerializer().Deserialize<LoginInfoModel>(stringObject);
        }

        public static string GetPackageServiceJson(LoginInfoModel obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
        public static string MaHoaMD5(string text)
        {
            var md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(text);
            bs = md5Hasher.ComputeHash(bs);
            var s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }
    }
}