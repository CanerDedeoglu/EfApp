using Microsoft.EntityFrameworkCore;

namespace EfApp.Data
{
    public class DataContext: DbContext
    {
        // Veri tabanı tabloları burada tanımlanır.
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }
        public DbSet<Bootcamp> Bootcamps => Set<Bootcamp>();
        public DbSet<Ogrenci> Ogrencis => Set<Ogrenci>();
        public DbSet<BootcampKayit> Kayitlar => Set<BootcampKayit>();

    }
}