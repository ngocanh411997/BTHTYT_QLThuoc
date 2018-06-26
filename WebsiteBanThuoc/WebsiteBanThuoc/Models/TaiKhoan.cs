namespace WebsiteBanThuoc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(150)]
        public string Username { get; set; }

        [StringLength(150)]
        public string Pass { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }
    }
}
