using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Models
{
    public enum Phanloai
    {
        [Display(Name ="Món")]
        Monan = 1,
        [Display(Name ="Combo")]
        Combo = 2,
        [Display(Name ="Nước")]
        Nuoc = 3,
    }
    public class MonAn
    {
        [Key]
        public int MonanID { get; set; }
        [StringLength(250)]
        [Required(ErrorMessage = "Bạn cần nhập tên")]
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bạn cần nhập giá"), Range(0, double.MaxValue, ErrorMessage = "Bạn Cần nhập Giá")]
        [Display(Name = "Giá")]
        public double Gia { get; set; }
        [Display(Name = "Phân Loại")]
        [Required(ErrorMessage = "Bạn cần chọn phân loại."), Range(1, int.MaxValue, ErrorMessage = "Bạn Cần chọn phân loại")]
        public Phanloai Phanloai { get; set; }
        [StringLength(100)]
        [Display(Name = "Hình")]
        public string Hinh { get; set; }
        [NotMapped]
        [Display(Name = "chọn Hình ")]
        public IFormFile ImageFile { get; set; }
        [StringLength(250)]
        [Display(Name ="Mô Tả")]
        public string Mota { get; set; }
        [Display(Name ="Đang Phục Vụ ")]
        public bool Trangthai { get; set; }

    }
}
