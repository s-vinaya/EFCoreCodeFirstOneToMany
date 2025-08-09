using Microsoft.EntityFrameworkCore;

namespace EFMVCLastDayPractise.Models
{
    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=DESKTOP-GKOPV5L;database=HotelDb;integrated security=true;trustservercertificate=true;");
            }
        }
    }
   
}
