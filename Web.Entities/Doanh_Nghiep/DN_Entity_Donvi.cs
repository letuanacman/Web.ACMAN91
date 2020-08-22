using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Web.Entities
{
    public class DN_Entity_Donvi
    {
        [StringLength(250)]
        public string Cap_tren { get; set; }

        [StringLength(250)]
        public string Ten_dv { get; set; }

        [StringLength(250)]
        public string Ten_dv_English { get; set; }

        [StringLength(50)]
        public string Ma_so { get; set; }

        public short? Nam_tc { get; set; }

        [StringLength(250)]
        public string dia_chi { get; set; }

        [StringLength(200)]
        public string QHuyen { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(50)]
        public string TK { get; set; }

        [StringLength(255)]
        public string NHang { get; set; }

        [StringLength(255)]
        public string TP { get; set; }

        [StringLength(100)]
        public string Giamdoc { get; set; }

        [StringLength(100)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public Int16? HTGS { get; set; }

        

        [StringLength(10)]
        public string NGAYBD { get; set; }

        [StringLength(100)]
        public string Cqthue { get; set; }

        [StringLength(100)]
        public string NganhNgheKD { get; set; }

        [StringLength(20)]
        public string MST_Cap_tren { get; set; }

        [StringLength(200)]
        public string TenDLyThue { get; set; }

        [StringLength(250)]
        public string DiaChiThue { get; set; }

        [StringLength(100)]
        public string Q_Huyen_Thue { get; set; }

        [StringLength(100)]
        public string TinhTP_Thue { get; set; }

        [StringLength(30)]
        public string DT_Thue { get; set; }

        [StringLength(20)]
        public string Fax_Thue { get; set; }

        [StringLength(50)]
        public string Email_Thue { get; set; }

        [StringLength(15)]
        public string Ngay_Thue { get; set; }

        [StringLength(20)]
        public string MaSo_Thue { get; set; }

        [StringLength(50)]
        public string HDong_Thue { get; set; }

        [StringLength(50)]
        public string Chungchi_Thue { get; set; }

        [StringLength(50)]
        public string NhanVien_Thue { get; set; }

        [StringLength(10)]
        public string NGAY_THANHLAP { get; set; }

        [StringLength(10)]
        public string NGAY_THAYDOI { get; set; }

        public short? SOLAN_THAYDOI { get; set; }
        [StringLength(10)]
        public string WEBSITE { get; set; }



    }
}
