using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class DN_Entity_UserList
    {
        [Key]
        public int U_ID { get; set; }

        [StringLength(100)]
        public string FULLNAME { get; set; }

        [StringLength(30)]
        public string USERNAME { get; set; }

        [StringLength(200)]
        public string PASSWORD { get; set; }

        public byte? QUYEN { get; set; }

        public short? AN_HIEN { get; set; }

        [StringLength(15)]
        public string PHIEU_KT { get; set; }

        public short? DOLON { get; set; }

        public byte? LOAI { get; set; }

        public long? CAP { get; set; }

        [StringLength(30)]
        public string ID_MA { get; set; }

        [StringLength(20)]
        public string TK_KHO { get; set; }

        [StringLength(20)]
        public string TK_DTHU { get; set; }

        public int? TRANGTHAI { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        public byte? KY_DUYET { get; set; }

        [StringLength(50)]
        public string TINH_TP { get; set; }

        [StringLength(100)]
        public string QUAN_HUYEN { get; set; }

        [StringLength(20)]
        public string NHOM_HDKT { get; set; }

        public long? P_U_ID { get; set; }

        [StringLength(30)]
        public string DIEN_THOAI { get; set; }

    }
}
