using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;
using Web.Entities.Doanh_Nghiep;

namespace Web.DL
{
  public  class DN_DL_Login 
    {
        public DN_Entity_UserList ValidLogIn(string UserName,string Pass,string ConnStr)
        {
            DN_Entity_UserList Userlist = new DN_Entity_UserList();
              using (DN_DbContext db = new DN_DbContext(ConnStr))
            {
                using (SqlConnection myConn = db.DN_ConnectionString( ))
                {
                    SqlCommand myCommand = new SqlCommand("Select_All_Table", myConn);
                     myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@Field", SqlDbType.NVarChar).Value = "TOP 1 *";
                    myCommand.Parameters.Add("@Where", SqlDbType.NVarChar).Value = "Upper(USERNAME) = N'" + UserName.ToUpper().ToString() + "' and Upper(PASSWORD) = N'" + Pass.ToUpper().ToString() + "'"; ;
                    myCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = "";
                    myCommand.Parameters.Add("@Tbl", SqlDbType.NVarChar).Value = "USER_LIST";
                    //return (ret == 1);
                    SqlDataReader dr = myCommand.ExecuteReader();
                     while (dr.Read())
                    {
                        Userlist.U_ID = (dr["U_ID"] is DBNull) ? Int32.MinValue : Convert.ToInt32(dr["U_ID"]);
                        Userlist.USERNAME = (dr["USERNAME"] is DBNull) ? String.Empty : (String)dr["USERNAME"];
                        Userlist.FULLNAME = (dr["FULLNAME"] is DBNull) ? String.Empty : (String)dr["FULLNAME"];
                        Userlist.AN_HIEN = (dr["AN_HIEN"] is DBNull) ? short.MinValue: Convert.ToInt16(dr["U_ID"]);
                        Userlist.QUYEN = (dr["U_ID"] is DBNull) ? byte.MinValue : Convert.ToByte(dr["U_ID"]);
                        Userlist.CAP = (dr["CAP"] is DBNull) ? byte.MinValue : Convert.ToInt64(dr["CAP"]);
                        Userlist.LOAI= (dr["LOAI"] is DBNull) ? byte.MinValue : Convert.ToByte(dr["LOAI"]);
                        Userlist.ID_MA = (dr["ID_MA"] is DBNull) ? String.Empty : (String)dr["ID_MA"];
                        Userlist.PHIEU_KT = (dr["PHIEU_KT"] is DBNull) ? String.Empty : (String)dr["PHIEU_KT"];
                        Userlist.DOLON = (dr["DOLON"] is DBNull) ? byte.MinValue : Convert.ToByte(dr["DOLON"]); 
                    }
                    
                }
                
            }
            return Userlist;
        }
    }
}
