using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data; 

namespace Web.DL
{
    public class DN_DbContext
    {
        /// <summary>
        /// Kết nối database Doanh nghiệp
        /// </summary>
        /// 
        //server=171.244.27.197;database=qlkh_banquyen;trusted_connection=false;uid=sa;pwd=acman3012016))((** 
        protected string ConnStr = "";
        public DN_DbContext(string Connstr1)
        {
            ConnStr = Connstr1;
        }
              
        protected SqlConnection DN_ConnectionString()
        {
            
            SqlConnection myConn = new SqlConnection(ConnStr);
            if (myConn.State == ConnectionState.Open)
                myConn.Close();
            myConn.Open();
            return myConn;
           
        }

    }
}
