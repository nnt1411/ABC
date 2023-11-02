namespace KiemTraThu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(10)]
        [Display(Name = "Mã SV")]
        public string MaSV { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ SV")]
        public string HoSV { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên SV")]
        public string TenSV { get; set; }

        [Display(Name = "Ngày Sinh")]

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Display(Name = "Giới Tính")]
        public bool? GioiTinh { get; set; }

        public byte[] AnhSV { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string MaLop { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
