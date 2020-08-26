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
    public class DN_DL_BangTK
    {
        private DN_Entity_BangTK GetBangTKFromReader(IDataReader dr)
        {
            DN_Entity_BangTK obj = new DN_Entity_BangTK();
            obj.ID = (dr["ID"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["ID"]);
            obj.CAPTK= (dr["CAPTK"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["CAPTK"]);
            obj.SO_TK = (dr["SO_TK"] is DBNull) ? String.Empty : (String)dr["SO_TK"];
            obj.TEN_TK = (dr["TEN_TK"] is DBNull) ? String.Empty : (String)dr["TEN_TK"];
            obj.MA_TK = (dr["MA_TK"] is DBNull) ? String.Empty : (String)dr["MA_TK"];
            obj.ENGLISH = (dr["ENGLISH"] is DBNull) ? String.Empty : (String)dr["ENGLISH"];
            obj.CT = (dr["CT"] is DBNull) ? String.Empty : (String)dr["CT"];
            obj.GHICHU = (dr["GHICHU"] is DBNull) ? String.Empty : (String)dr["GHICHU"];
            obj.SUDUNG = (dr["SUDUNG"] is DBNull) ? false : (Boolean)dr["SUDUNG"];
            obj.DU_NO = (dr["DU_NO"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["DU_NO"]);
            obj.DU_CO = (dr["DU_CO"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["DU_CO"]);
            obj.NAMTC = (dr["NAMTC"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["NAMTC"]);
            return obj;
        }

        /// <summary>
        /// Returns a collection of BangTK with the data read from the input DataReader
        /// </summary>
        private List<DN_Entity_BangTK> GetBangTKCollectionFromReader(IDataReader dr)
        {
            List<DN_Entity_BangTK> obj = new List<DN_Entity_BangTK>();
            while (dr.Read())
                obj.Add(GetBangTKFromReader(dr));
            return obj;
        }

        // Search DoanhNghieps
        public List<DN_Entity_BangTK> GetBangTK(int NamTC, int PageIndex, int PageSize )
        {
            
            using (DN_DbContext db = new DN_DbContext())
            {
                using (SqlConnection myConn = db.DN_ConnectionString())
                {
                    SqlCommand myCommand = new SqlCommand("Select_All_Table", myConn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@Field", SqlDbType.NVarChar).Value = "*";
                    myCommand.Parameters.Add("@Where", SqlDbType.NVarChar).Value = "NAMTC = " + NamTC;
                    myCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = "SO_TK";
                    myCommand.Parameters.Add("@Tbl", SqlDbType.NVarChar).Value = "BANGTK";
                    SqlDataReader dr = myCommand.ExecuteReader();
                    return GetBangTKCollectionFromReader(dr);
                }
            }

        }

        public double GetTongDuNoCo(int NamTC,bool IsDuNo)
        {
            double giatri = 0;
            using (DN_DbContext db = new DN_DbContext())
            {
                using (SqlConnection myConn = db.DN_ConnectionString())
                {
                    SqlCommand myCommand = new SqlCommand("Select_All_Table", myConn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@Field", SqlDbType.NVarChar).Value = IsDuNo? "SUM(DU_NO) AS TONG" : "SUM(DU_NO) AS TONG";
                    myCommand.Parameters.Add("@Where", SqlDbType.NVarChar).Value = "NAMTC = " + NamTC;
                    myCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = "";
                    myCommand.Parameters.Add("@Tbl", SqlDbType.NVarChar).Value = "BANGTK";
                    SqlDataReader dr = myCommand.ExecuteReader();
                   while (dr.Read())
                        giatri = (dr["TONG"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TONG"]);
                    return giatri;
                }
            }

        }

    }
}
