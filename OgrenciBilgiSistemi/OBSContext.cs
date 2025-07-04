using Microsoft.EntityFrameworkCore;

namespace OgrenciBilgiSistemi
{
    public class OBSContext : DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Grade> Notlar { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().HasIndex(o => o.OgrenciNo).IsUnique();

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-IBCCD9T\SQLEXPRESS;Database=OgrenciBilgiSistemi;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

    }
}
