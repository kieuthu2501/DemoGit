using System.ComponentModel.DataAnnotations;




namespace KieuThuXuan_DoAn.Models
{
    public partial class KhachHang
    {
        [Key]
        public int IDKH { get; set; }
        public string TenKH { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

    }
}

