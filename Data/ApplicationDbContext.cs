// filepath: /C:/Users/davin/4870 Workspace/Lab3/Data/ApplicationDbContext.cs
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace Lab3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Province>().HasData(
                new Province { ProvinceCode = "ON", ProvinceName = "Ontario" },
                new Province { ProvinceCode = "QC", ProvinceName = "Quebec" },
                new Province { ProvinceCode = "BC", ProvinceName = "British Columbia" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, CityName = "Toronto", Population = 2731571, Province = "ON" },
                new City { CityId = 2, CityName = "Montreal", Population = 1704694, Province = "QC" },
                new City { CityId = 3, CityName = "Vancouver", Population = 631486, Province = "BC" }
            );
        }
    }
}