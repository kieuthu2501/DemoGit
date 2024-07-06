using Microsoft.EntityFrameworkCore;

namespace KieuThuXuan_DoAn.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<SanPhamm> SanPhams { get; set; }
		public DbSet<KhachHang> KhachHangs { get; set; }
		public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<CTHD> CTHDs { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SanPhamm>(entity =>
			{
				entity.ToTable("SanPham");
				entity.Property(e => e.IDSP).HasColumnName("IDSP");
				entity.Property(e => e.TenSP).IsRequired().HasMaxLength(500);
				entity.Property(e => e.LoaiSP).IsRequired().HasMaxLength(500);
				entity.Property(e => e.GiaSP).IsRequired();
				entity.Property(e => e.NgayNhap).HasColumnType("date");
				entity.Property(e => e.TonKho).IsRequired();
				entity.Property(e => e.MoTa).HasColumnType("ntext");
				//entity.Property(e => e.Anh).IsRequired();
			});

			modelBuilder.Entity<KhachHang>(entity =>
			{
				entity.ToTable("KhachHang");
				entity.Property(e => e.IDKH).HasColumnName("IDKH");
				entity.Property(e => e.TenKH).IsRequired().HasMaxLength(500);
				entity.Property(e => e.DiaChi).IsRequired().HasMaxLength(500);
				entity.Property(e => e.NgaySinh).HasColumnType("date");
				entity.Property(e => e.SDT).IsRequired().HasMaxLength(100);

			});

			modelBuilder.Entity<HoaDon>(entity =>
			{
				entity.ToTable("HoaDon");
				entity.Property(e => e.IDHD).HasColumnName("IDHD");
				entity.Property(e => e.IDKH).HasColumnName("IDKH");

				entity.Property(e => e.NgayLap).HasColumnType("date");
				entity.Property(e => e.HTTT).IsRequired().HasMaxLength(100);

			});

			modelBuilder.Entity<CTHD>(entity =>
			{
				entity.ToTable("CTHD");
				entity.Property(e => e.IDHD).HasColumnName("IDHD");
				entity.Property(e => e.IDSP).HasColumnName("IDSP");

				entity.Property(e => e.SoLuong).HasColumnName("SoLuong");

            });
		}
	}
}

