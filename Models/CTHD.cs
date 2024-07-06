using System.ComponentModel.DataAnnotations;


namespace KieuThuXuan_DoAn.Models
{
    public partial class CTHD
    {
        [Key]
        public int IDHD { get; set; }
        public int IDSP { get; set; }
        public string SoLuong { get; set; }
       
    }
}
