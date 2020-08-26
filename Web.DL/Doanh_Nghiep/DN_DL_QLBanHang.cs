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
    public class DN_DL_QLBanHang
    {
        private DN_Entity_ShopBanHang GetHoadonBanHang_FromReader(IDataReader dr)
        {
            DN_Entity_ShopBanHang obj = new DN_Entity_ShopBanHang();
            obj.SHOP_ID = (dr["SHOP_ID"] is DBNull) ? String.Empty : (String)dr["SHOP_ID"];
            obj.SO_DONHANG = (dr["SO_DONHANG"] is DBNull) ? String.Empty : (String)dr["SO_DONHANG"];
            obj.NAM_TC = (dr["NAM_TC"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["NAM_TC"]);
            obj.THANG = (dr["THANG"] is DBNull) ? short.MinValue : Convert.ToInt16(dr["THANG"]);
            obj.NGAY = (dr["NGAY"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dr["NGAY"]);
            obj.NGAYTT = (dr["NGAYTT"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dr["NGAYTT"]);
            obj.NGAY_GIAOHANG = (dr["NGAY_GIAOHANG"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dr["NGAY_GIAOHANG"]);
            obj.NGAY_COHANG = (dr["NGAY_COHANG"] is DBNull) ? DateTime.MinValue : Convert.ToDateTime(dr["NGAY_COHANG"]);
            obj.MAUFULLHD = (dr["MAUFULLHD"] is DBNull) ? String.Empty : (String)dr["MAUFULLHD"];
            obj.KYHIEU_HD = (dr["KYHIEU_HD"] is DBNull) ? String.Empty : (String)dr["KYHIEU_HD"];
            obj.SO_HD = (dr["SO_HD"] is DBNull) ? String.Empty : (String)dr["SO_HD"];
            obj.TIEN_HANG = (dr["TIEN_HANG"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_HANG"]);
            obj.TIEN_GGIA = (dr["TIEN_GGIA"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_GGIA"]);
            obj.CHIET_KHAU = (dr["CHIET_KHAU"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["CHIET_KHAU"]);
            obj.TILE_CKHAU = (dr["TILE_CKHAU"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TILE_CKHAU"]);
            obj.THUE_VAT = (dr["THUE_VAT"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["THUE_VAT"]);
            obj.TILE_VAT = (dr["TILE_VAT"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TILE_VAT"]);
            obj.TONG_TIEN = (dr["TONG_TIEN"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TONG_TIEN"]);
            obj.TIEN_DATCOC = (dr["TIEN_DATCOC"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_DATCOC"]);
            obj.TIEN_CNO = (dr["TIEN_CNO"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_CNO"]);
            obj.TIEN_CARD = (dr["TIEN_CARD"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_CARD"]);
            obj.TIEN_VOUCHER = (dr["TIEN_VOUCHER"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_VOUCHER"]);
            obj.TIEN_MAT = (dr["TIEN_MAT"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_MAT"]);
            obj.TIEN_CNO_COD = (dr["TIEN_CNO_COD"] is DBNull) ? double.MinValue : Convert.ToDouble(dr["TIEN_CNO_COD"]);
            obj.TK_CO = (dr["TK_CO"] is DBNull) ? String.Empty : (String)dr["TK_CO"];
            obj.TK_CNO = (dr["TK_CNO"] is DBNull) ? String.Empty : (String)dr["TK_CNO"];
            obj.TK_CARD = (dr["TK_CARD"] is DBNull) ? String.Empty : (String)dr["TK_CARD"];
            obj.TK_VOUCHER = (dr["TK_VOUCHER"] is DBNull) ? String.Empty : (String)dr["TK_VOUCHER"];
            obj.TK_TM = (dr["TK_TM"] is DBNull) ? String.Empty : (String)dr["TK_TM"];
            obj.MA_VT = (dr["MA_VT"] is DBNull) ? String.Empty : (String)dr["MA_VT"];
            obj.TEN_VT = (dr["TEN_VT"] is DBNull) ? String.Empty : (String)dr["TEN_VT"];
            obj.DIA_CHI = (dr["DIA_CHI"] is DBNull) ? String.Empty : (String)dr["DIA_CHI"];
            obj.DIA_CHI_NHAN = (dr["DIA_CHI_NHAN"] is DBNull) ? String.Empty : (String)dr["DIA_CHI_NHAN"];
            obj.EMAIL = (dr["EMAIL"] is DBNull) ? String.Empty : (String)dr["EMAIL"];
            obj.USER_NAME = (dr["USER_NAME"] is DBNull) ? String.Empty : (String)dr["USER_NAME"];
            obj.MA_VOUCHER = (dr["MA_VOUCHER"] is DBNull) ? String.Empty : (String)dr["MA_VOUCHER"];
            obj.MA_CARD = (dr["MA_CARD"] is DBNull) ? String.Empty : (String)dr["MA_CARD"];
            obj.NV_PHUCVU = (dr["NV_PHUCVU"] is DBNull) ? String.Empty : (String)dr["NV_PHUCVU"];
            obj.NV_GIAOHANG = (dr["NV_GIAOHANG"] is DBNull) ? String.Empty : (String)dr["NV_GIAOHANG"];
            obj.TINH_TRANG = (dr["TINH_TRANG"] is DBNull) ? String.Empty : (String)dr["TINH_TRANG"];
            obj.ID_USER = (dr["ID_USER"] is DBNull) ? String.Empty : (String)dr["ID_USER"];
            obj.GHI_CHU2 = (dr["GHI_CHU2"] is DBNull) ? String.Empty : (String)dr["GHI_CHU2"];
            obj.GHI_CHU = (dr["GHI_CHU"] is DBNull) ? String.Empty : (String)dr["GHI_CHU"];

            obj.TRA_LAI = (dr["TRA_LAI"] is DBNull) ? false : (Boolean)dr["TRA_LAI"];
            obj.KHOA_SO = (dr["KHOA_SO"] is DBNull) ? false : (Boolean)dr["KHOA_SO"];
            obj.KY_BANHANG = (dr["KY_BANHANG"] is DBNull) ? false : (Boolean)dr["KY_BANHANG"];
            obj.KY_KHO = (dr["KY_KHO"] is DBNull) ? false : (Boolean)dr["KY_KHO"];
            obj.KY_KT_BANHANG = (dr["KY_KT_BANHANG"] is DBNull) ? false : (Boolean)dr["KY_KT_BANHANG"];
            obj.KY_QL_BANHANG = (dr["KY_QL_BANHANG"] is DBNull) ? false : (Boolean)dr["KY_QL_BANHANG"];
            obj.HOAN_THANH = (dr["HOAN_THANH"] is DBNull) ? false : (Boolean)dr["HOAN_THANH"];

            obj.LOAI_DONHANG = (dr["LOAI_DONHANG"] is DBNull) ? byte.MinValue : Convert.ToByte(dr["LOAI_DONHANG"]);
            obj.TRANG_THAI_DH = (dr["TRANG_THAI_DH"] is DBNull) ? byte.MinValue : Convert.ToByte(dr["TRANG_THAI_DH"]);

            return obj;
        }

        /// <summary>
        /// Returns a collection of BangTK with the data read from the input DataReader
        /// </summary>
        private List<DN_Entity_ShopBanHang> GetHoadonBanHang_CollectionFromReader(IDataReader dr)
        {
            List<DN_Entity_ShopBanHang> obj = new List<DN_Entity_ShopBanHang>();
            while (dr.Read())
                obj.Add(GetHoadonBanHang_FromReader(dr));
            return obj;
        }

        // Search DoanhNghieps
        public List<DN_Entity_ShopBanHang> GetHoadonBanHang(int NamTC, int PageIndex, int PageSize, int Loai)
        {

            using (DN_DbContext db = new DN_DbContext())
            {
                using (SqlConnection myConn = db.DN_ConnectionString())
                {
                    SqlCommand myCommand = new SqlCommand("Select_All_Table", myConn);
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.Add("@Field", SqlDbType.NVarChar).Value = "*";
                    myCommand.Parameters.Add("@Where", SqlDbType.NVarChar).Value = "LOAI = " + Loai + " and NAM_TC = " + NamTC;
                    myCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = "NGAY";
                    myCommand.Parameters.Add("@Tbl", SqlDbType.NVarChar).Value = "SHOP_BANHANG";
                    SqlDataReader dr = myCommand.ExecuteReader();
                    return GetHoadonBanHang_CollectionFromReader(dr);
                }
            }

        }
    }
}
