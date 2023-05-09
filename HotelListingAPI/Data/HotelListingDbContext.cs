using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Brazil",
                    ShortName = "BR"
                },

                new Country
                {
                      Id = 2,
                      Name = "Australia",
                      ShortName = "AU"
                },
                new Country
                {
                    Id = 3,
                    Name = "Canada",
                    ShortName = "CA"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Brasilian Hotel",
                    Address = "Belo Horizonte",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Australian Hotel",
                    Address = "Sydney",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Canadian Hotel",
                    Address = "Toronto",
                    CountryId = 3,
                    Rating = 4.6
                }
            );
        }
    }
}
