using Microsoft.EntityFrameworkCore;

namespace sinemaotomasyonu.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {
            //bu bir constructor bu constructor her çağrıldığında veritabanına bağlanması ve işlemlerin yapılmasını sağlayacak kalıptır.Başka şekilde bağlantılarda yapılabilir.
        }
       
        public DbSet<Mekan> mekanlars { get; set; }
        public DbSet<Filmler> filmlers { get; set;}
        public DbSet<Koltuklar> koltuklars { get; set; }
        public DbSet<Görevli> görevlis { get; set; }
        public DbSet<Seanslar> seanslars { get; set; }
        public DbSet<İzleyiciler> izleyicilers { get; set; }
    }
}
