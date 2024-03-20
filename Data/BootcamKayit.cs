using System.ComponentModel.DataAnnotations;

namespace EfApp.Data
{
    public class BootcampKayit
    {
        [Key]
        public int KayıtId { get; set; }
        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; } = null!;
        public int KursId { get; set; }
        public Bootcamp Bootcamp { get; set; } = null!;
        public DateTime KayitTarihi { get; set; }
    }
}
