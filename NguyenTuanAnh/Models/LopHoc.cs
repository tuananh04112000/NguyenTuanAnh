using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenTuanAnh.Models
{
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }
        [Required]
        [StringLength(50)]
        public string TenLop  { get; set; }
    }
}