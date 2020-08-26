using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class DN_Entity_ShopBanHang
    {
        [Key]
        [StringLength(37)]
        public string SHOP_ID { get; set; }

        public short? NAM_TC { get; set; }

        public short? THANG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY { get; set; }

        [StringLength(15)]
        public string MAUFULLHD { get; set; }

        [StringLength(10)]
        public string KYHIEU_HD { get; set; }

        [StringLength(10)]
        public string SO_HD { get; set; }

        public double? TIEN_HANG { get; set; }

        public double? TIEN_GGIA { get; set; }

        public double? CHIET_KHAU { get; set; }

        public double? TILE_CKHAU { get; set; }

        public double? THUE_VAT { get; set; }

        public double? TILE_VAT { get; set; }

        public double? TONG_TIEN { get; set; }

        public double? TIEN_DATCOC { get; set; }

        [StringLength(30)]
        public string USER_NAME { get; set; }

        [StringLength(15)]
        public string TK_TM { get; set; }

        public double? TIEN_MAT { get; set; }

        [StringLength(15)]
        public string TK_CNO { get; set; }

        public double? TIEN_CNO { get; set; }

        [StringLength(15)]
        public string TK_CARD { get; set; }

        [StringLength(30)]
        public string MA_CARD { get; set; }

        public double? TIEN_CARD { get; set; }

        [StringLength(15)]
        public string TK_VOUCHER { get; set; }

        [StringLength(30)]
        public string MA_VOUCHER { get; set; }

        public double? TIEN_VOUCHER { get; set; }

        [StringLength(30)]
        public string MA_VT { get; set; }

        [StringLength(150)]
        public string TEN_VT { get; set; }

        [StringLength(40)]
        public string TEL { get; set; }

        [StringLength(250)]
        public string DIA_CHI { get; set; }

        [StringLength(20)]
        public string MST { get; set; }

        [StringLength(15)]
        public string TK_CO { get; set; }

        public byte? LOAI { get; set; }

        [StringLength(250)]
        public string GHI_CHU { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYTT { get; set; }

        [StringLength(10)]
        public string SO_DONHANG { get; set; }

        public bool? KHOA_SO { get; set; }

        [StringLength(70)]
        public string NV_PHUCVU { get; set; }
        [StringLength(70)]
        public string NV_GIAOHANG { get; set; }
        public bool? TRA_LAI { get; set; }

        public double? GIAMGIA_KHAC { get; set; }

        [StringLength(15)]
        public string MA_LIENKET { get; set; }

        [StringLength(70)]
        public string TINH_TRANG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_GIAOHANG { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAY_COHANG { get; set; }

        [StringLength(30)]
        public string ID_USER { get; set; }

        public bool? KY_BANHANG { get; set; }

        public bool? KY_QL_BANHANG { get; set; }

        public bool? KY_KT_BANHANG { get; set; }

        [StringLength(250)]
        public string GHI_CHU2 { get; set; }

        public double? FILE_SIZE { get; set; }

        public bool? CHK_UPLOAD { get; set; }

        [StringLength(50)]
        public string FILE_ATTACH { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public byte TRANG_THAI_DH { get; set; }

        public byte? LOAI_DONHANG { get; set; }

        public bool? KY_KHO { get; set; }

        public bool? KY_DIEUPHOI { get; set; }

        [StringLength(70)]
        public string TEN_NGUOI_NHAN { get; set; }

        [StringLength(50)]
        public string TEL_NGUOI_NHAN { get; set; }

        [StringLength(250)]
        public string DIA_CHI_NHAN { get; set; }

        public bool? VAN_CHUYEN { get; set; }

        public bool? LAP_DAT { get; set; }

        public bool? HOPDONG_KT { get; set; }

        [StringLength(40)]
        public string TEN_TRANG_THAI_DH { get; set; }

        public bool? HOADON_VAT { get; set; }

        public bool? KY_VAT { get; set; }

        public bool? HOAN_THANH { get; set; }

        public double? TIEN_CNO_COD { get; set; }
    }
}
