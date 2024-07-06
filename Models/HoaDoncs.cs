using System.ComponentModel.DataAnnotations;




namespace KieuThuXuan_DoAn.Models
{
    public partial class HoaDon
    {
        [Key]
        public int IDHD { get; set; }
        public int IDKH { get; set; }
        public DateTime NgayLap { get; set; }
        public string HTTT { get; set; }
       

    }
}

