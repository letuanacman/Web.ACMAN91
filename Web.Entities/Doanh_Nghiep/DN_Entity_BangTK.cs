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
        public short? CAPTK { get; set; }

        [StringLength(50)]
        public string MA_TK { get; set; }

        [StringLength(15)]
        public string SO_TK { get; set; }

        [StringLength(100)]
        public string TEN_TK { get; set; }

        [StringLength(100)]
        public string ENGLISH { get; set; }

        [StringLength(100)]
        public string OTHER { get; set; }

        public double? DU_NO { get; set; }

        public double? DU_CO { get; set; }

        [StringLength(5)]
        public string CT { get; set; }

        [StringLength(50)]
        public string MAU { get; set; }

        public short? NAMTC { get; set; }


        [StringLength(100)]
        public string GHICHU { get; set; }

        public bool? SUDUNG { get; set; }

        [StringLength(100)]
        public string GHICHU2 { get; set; }
    }
}
