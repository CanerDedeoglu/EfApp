using System.ComponentModel.DataAnnotations;

namespace EfApp.Data
{
    public class BootcampKayit
    {
       [Key]
       public int KayıtId { get; set; }
       public int OgrenciId { get; set; }
       public int KursId { get; set; }
       public DateTime KayitTarihi { get; set; }
    }
}
