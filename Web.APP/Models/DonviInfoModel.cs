using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.APP.Models
{
    public class DonviInfoModel
    {
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

    }
}