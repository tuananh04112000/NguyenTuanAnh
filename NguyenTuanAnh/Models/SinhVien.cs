using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenTuanAnh.Models
{
    public class SinhVien
    {
        [Key]
        [StringLength(20)]
        public string MaSinhVien  { get; set; }
        [Required]
        [StringLength(50)]
        public string HoTen  { get; set; }

    }
}