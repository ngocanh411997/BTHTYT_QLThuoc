namespace WebsiteBanThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        public int MaThuoc { get; set; }

        [StringLength(200)]
        public string TenThuoc { get; set; }

        public decimal? GiaBan { get; set; }

        public string MoTa { get; set; }

        [StringLength(50)]
        public string AnhBia { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongTon { get; set; }

        public int? MaTH { get; set; }

        public int? MaDM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
