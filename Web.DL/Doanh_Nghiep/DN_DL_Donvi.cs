using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entities;

namespace Web.DL
{
    public class DN_DL_Donvi
    {
        public DN_Entity_Donvi GetDonvi()
        {
            DN_Entity_Donvi Dv = new DN_Entity_Donvi();
            using (DN_DbContext db = new DN_DbContext())
            {
                using (SqlConnection myConn = db.DN_ConnectionString())
                {
                    SqlCommand myCommand = new SqlCommand("Select_All_Table", myConn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@Field", SqlDbType.NVarChar).Value = "TOP 1 *";
                    myCommand.Parameters.Add("@Where", SqlDbType.NVarChar).Value = "";
                    myCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = "";
                    myCommand.Parameters.Add("@Tbl", SqlDbType.NVarChar).Value = "DONVI";

                    SqlDataReader dr = myCommand.ExecuteReader();
                    while (dr.Read())
                    {
                        Dv.Nam_tc = (dr["Nam_tc"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["Nam_tc"]);
                        Dv.Ma_so = (dr["Ma_so"] is DBNull) ? String.Empty : (String)dr["Ma_so"];
                        Dv.Ten_dv = (dr["Ten_dv"] is DBNull) ? String.Empty : (String)dr["Ten_dv"];
                        Dv.Ten_dv_English = (dr["Ten_dv_English"] is DBNull) ? String.Empty : (String)dr["Ten_dv_English"];
                        Dv.dia_chi = (dr["dia_chi"] is DBNull) ? String.Empty : (String)dr["dia_chi"];
                        Dv.QHuyen = (dr["QHuyen"] is DBNull) ? String.Empty : (String)dr["QHuyen"];
                        Dv.City = (dr["City"] is DBNull) ? String.Empty : (String)dr["City"];
                        Dv.TK = (dr["TK"] is DBNull) ? String.Empty : (String)dr["TK"];
                        Dv.Email = (dr["Email"] is DBNull) ? String.Empty : (String)dr["Email"];
                        Dv.NHang = (dr["NHang"] is DBNull) ? String.Empty : (String)dr["NHang"];
                        Dv.WEBSITE = (dr["WEBSITE"] is DBNull) ? String.Empty : (String)dr["WEBSITE"];
                        Dv.Giamdoc = (dr["Giamdoc"] is DBNull) ? String.Empty : (String)dr["Giamdoc"]; 
                    }

                }

            }
            return Dv;
        }
    }
}
