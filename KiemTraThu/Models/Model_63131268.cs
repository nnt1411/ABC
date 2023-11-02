using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KiemTraThu.Models
{
    public partial class Model_63131268 : DbContext
    {
        public Model_63131268()
            : base("name=Model_63131268")
        {
        }

        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaLop)
                .IsUnicode(false);
        }
    }
}
