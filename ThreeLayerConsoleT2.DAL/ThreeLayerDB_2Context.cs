using Microsoft.EntityFrameworkCore;
using ThreeLayerConsoleT2.DAL.Entities;

namespace ThreeLayerConsoleT2.DAL
{
    public partial class ThreeLayerDB_2Context : DbContext
    {
        public ThreeLayerDB_2Context()
        {
        }

        public ThreeLayerDB_2Context(DbContextOptions<ThreeLayerDB_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=POWWA;Database=ThreeLayerDB_2;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSanP__730A5759A6C63A64");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoai).ValueGeneratedNever();

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.NgayTao).HasColumnType("date");

                entity.Property(e => e.TenLoai).HasMaxLength(100);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham)
                    .HasName("PK__SanPham__FAC7442DC875E987");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham).ValueGeneratedNever();

                entity.Property(e => e.GiaBan).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.HanSuDung).HasColumnType("date");

                entity.Property(e => e.MoTa).HasMaxLength(1000);

                entity.Property(e => e.NgaySanXuat).HasColumnType("date");

                entity.Property(e => e.NhaSanXuat).HasMaxLength(100);

                entity.Property(e => e.TenSanPham).HasMaxLength(150);

                entity.Property(e => e.XuatXu).HasMaxLength(100);

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaLoai__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
