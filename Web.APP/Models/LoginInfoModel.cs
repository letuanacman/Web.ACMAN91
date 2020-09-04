using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.APP.Models
{
    [Serializable]
    public class LoginInfoModel
    {
        public string TEN_DATA { get; set; }
        public string TEN_DANGNHAP { get; set; }
        public String FULLNAME { get; set; }
        public int U_ID { get; set; }
    }
}