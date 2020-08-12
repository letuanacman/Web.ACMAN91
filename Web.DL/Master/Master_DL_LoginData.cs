using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Web.Entities;

namespace Web.DL
{
   public class Master_DL_LoginData : Master_DbContext
    {
        public Master_Entity_LoginData GetData_DoanhNghiep(string TenData)
        {
            using (SqlConnection myConn = GetConnectionString())
            {
                SqlCommand myCommand =  new SqlCommand("GET_SERVER_ONLINE_DATABASE_LOGIN", myConn);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add("@TEN_DATA", SqlDbType.NVarChar).Value = TenData;
                //int ret = myCommand.ExecuteNonQuery();
                //return (ret == 1);
                SqlDataReader dr =  myCommand.ExecuteReader();
                Master_Entity_LoginData obj = new Master_Entity_LoginData();
                while (dr.Read())
                {
                    obj.ID_DN = (dr["ID"] is DBNull) ? Int32.MinValue : Convert.ToInt32(dr["ID"]);
                    obj.Server = (dr["Server"] is DBNull) ? String.Empty : (String)dr["Server"];
                    obj.TenData = (dr["TEN_DATA"] is DBNull) ? String.Empty : (String)dr["TEN_DATA"];
                    obj.UserName = (dr["USER_NAME"] is DBNull) ? String.Empty : (String)dr["USER_NAME"];
                    obj.PassWord = (dr["PASSWORD"] is DBNull) ? String.Empty : (String)dr["PASSWORD"];
                }
                return obj;
            }
        }
    }
}
