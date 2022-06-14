using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HasashinShop.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        [StringLength(30, ErrorMessage = "Không dài quá {1} kí tự và không dưới {2} kí tự", MinimumLength = 3)]
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Tên Sản Phẩm")]
        public string TenSP { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(30, ErrorMessage = "Không dài quá {1} kí tự và không dưới {2} kí tự", MinimumLength = 1)]
        [Display(Name = "Giống loài")]
        public string LoaiSP { get; set; }
        [Display(Name = "Ngày nhập")]
        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime NgayMua { get; set; }
        [Range(1, 1000000000)]
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Giá")]
        [DisplayFormat(DataFormatString = "{0:#,0} đ")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Gia { get; set; }
        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Hình ảnh")]
        public string ImageProduct { get; set; }
    }

}
