using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanThuoc.Models
{
    [MetadataTypeAttribute(typeof(KhachHangMetadata))]
    public partial class KhachHang
    {
        internal sealed class KhachHangMetadata
        {
            public int MaKH { get; set; }

            [StringLength(50)]
            [Required(ErrorMessage = "{0} không được để trống")] // Kiểm tra rỗng
            [Display(Name = "Họ tên(*)")] // Dùng để đặt lại tên cho một cột
            public string HoTen { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]//Định dạng ngày sinh
            [Display(Name = "Ngày sinh")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public DateTime? NgaySinh { get; set; }

            [StringLength(50)]
            [Required(ErrorMessage = "{0} không được để trống")] // Kiểm tra rỗng
            [Display(Name = "Tài khoản(*)")] // Dùng để đặt lại tên cho một cột
            public string TaiKhoan { get; set; }

            [StringLength(50)]
            [Required(ErrorMessage = "{0} không được để trống")] // Kiểm tra rỗng
            [Display(Name = "Mật khẩu(*)")] // Dùng để đặt lại tên cho một cột
            public string MatKhau { get; set; }

            [StringLength(100)]
            public string Email { get; set; }

            [StringLength(200)]
            [Display(Name = "Địa chỉ")] // Dùng để đặt lại tên cho một cột
            public string DiaChi { get; set; }

            [StringLength(50)]
            [Display(Name = "Điện thoại(*)")] // Dùng để đặt lại tên cho một cột
            [Required(ErrorMessage = "{0} không được để trống")] // Kiểm tra rỗng
            public string DienThoai { get; set; }


        }
    }
}