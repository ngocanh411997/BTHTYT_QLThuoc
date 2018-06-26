using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanThuoc.Models
{
    [MetadataTypeAttribute(typeof(ThuocMetadata))]
    public partial class Thuoc
    {
        internal sealed class ThuocMetadata
        {
            [Display(Name = "Tên sản phẩm")]//Thuộc tính Display dùng để đặt tên lại cho cột
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] //Kiểm tra rổng
            public string TenThuoc { get; set; }
            [Display(Name = "Giá bán")]//Thuộc tính Display dùng để đặt tên lại cho cột
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] //Kiểm tra rổng
            public Nullable<decimal> GiaBan { get; set; }
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] //Kiểm tra rổng
            [Display(Name = "Mô tả")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public string MoTa { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]//Định dạng ngày sinh
            [Display(Name = "Ngày cập nhật")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public Nullable<System.DateTime> NgayCapNhat { get; set; }
            [Display(Name = "Ảnh bìa")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public string AnhBia { get; set; }
            [Display(Name = "Số lượng tồn")]//Thuộc tính Display dùng để đặt tên lại cho cột
            [Required(ErrorMessage = "Vui lòng nhập dữ liệu cho trường này.")] //Kiểm tra rổng
            public Nullable<int> SoLuongTon { get; set; }
            [Display(Name = "Danh Mục")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public Nullable<int> MaDM { get; set; }
            [Display(Name = "Thương Hiệu")]//Thuộc tính Display dùng để đặt tên lại cho cột
            public Nullable<int> MaTH { get; set; }
            
        }
    }
}