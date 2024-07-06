using System.ComponentModel.DataAnnotations;


namespace KieuThuXuan_DoAn.Models
{
	public partial class SanPhamm
	{
		[Key]
		public int IDSP { get; set; }
		public string? LoaiSP { get; set; }
		public string TenSP { get; set; }
		public long GiaSP { get; set; }
		public DateTime NgayNhap { get; set; }
		public int TonKho { get; set; }
		public string? MoTa { get; set; }
		public string? Anh { get; set; }
    }
}
