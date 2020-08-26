using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Entities 
{
  public  class DN_Entity_BangTK
    {

        public short ID { get; set; }
        [Display(Name ="Cấp TK")]
        public short? CAPTK { get; set; }

        [StringLength(50)]
        [Display(Name = "Mã TK")]
        public string MA_TK { get; set; }

        [StringLength(15)]
        [Display(Name = "Số tài khoản")]
        public string SO_TK { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên tài khoản")]
        public string TEN_TK { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên tài khoản English")]
        public string ENGLISH { get; set; }

        [StringLength(100)]
        [Display(Name = "Tên tài khoản ngôn ngữ khác")]
        public string OTHER { get; set; }
        [Display(Name = "Dư nợ")]
        public double? DU_NO { get; set; }
        [Display(Name = "Dư có")]
        public double? DU_CO { get; set; }

        [StringLength(5)]
        [Display(Name = "Chi tiết")]
        public string CT { get; set; }

        [StringLength(50)]
        public string MAU { get; set; }
        [Display(Name = "Năm tài chính")]
        public short? NAMTC { get; set; }


        [StringLength(100)]
        [Display(Name = "Ghi chú")]
        public string GHICHU { get; set; }
        [Display(Name = "Sử dụng")]
        public bool? SUDUNG { get; set; }

        [StringLength(100)]
        public string GHICHU2 { get; set; }
    }
}
