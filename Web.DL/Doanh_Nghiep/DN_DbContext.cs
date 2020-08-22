using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Runtime.InteropServices;
using System.Web;

namespace Web.DL
{
    public class DN_DbContext : IDisposable
    {
        /// <summary>
        /// Kết nối database Doanh nghiệp
        /// </summary>
        /// 
        //server=171.244.27.197;database=qlkh_banquyen;trusted_connection=false;uid=sa;pwd=acman3012016))((** 
        protected string ConnStr = "";
        public DN_DbContext()
        {
            try
            {
                ConnStr = HttpContext.Current.Session["DN_ConnectString"].ToString().Trim();
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public SqlConnection DN_ConnectionString()
        {
            try
            {

                SqlConnection myConn = new SqlConnection(ConnStr);
                if (myConn.State == ConnectionState.Open)
                    myConn.Close();
                myConn.Open();
                return myConn;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Dispose()
        {

        }

    }
}
