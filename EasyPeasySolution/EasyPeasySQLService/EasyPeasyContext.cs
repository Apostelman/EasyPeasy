

using EasyPeasyDataModel.Classes;
using Microsoft.EntityFrameworkCore;

namespace EasyPeasySQLService
{
    public class EasyPeasyContext : DbContext
    {

        
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EasyPeasy;Trusted_Connection=True;");
            options.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<AddressAddressType>()
                .HasKey(bc => new { bc.AddressID, bc.AddressTypeID });
        }
    }
}