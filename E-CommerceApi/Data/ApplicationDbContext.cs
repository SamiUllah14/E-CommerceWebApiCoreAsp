using E_CommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductClass> EcomProducts_API { get; set; }
        // EcomProducts_API will be the table name in the database

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductClass>().HasData(
                new ProductClass()
                {
                    Id = 1,
                    Name = "Jeans",
                    Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                    occupancy = 5,
                    Price = "$50",
                    Amenity = "Yes",
                    CreatedDate = DateTime.Now,
                },
                new ProductClass()
                {
                    Id = 2,
                    Name = "Men Shirt",
                    Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                    occupancy = 2,
                    Price = "$20",
                    Amenity = "No",
                    CreatedDate = DateTime.Now,

                },
                new ProductClass()
                {
                    Id = 3,
                    Name = "Baby Boy",
                    Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                    occupancy = 5,
                    Price = "$10",
                    Amenity = "Home",
                    CreatedDate = DateTime.Now,

                },
                new ProductClass()
                {
                    Id = 4,
                    Name = "Half Shirt",
                    Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                    occupancy = 5,
                    Price = "$2",
                    Amenity = "Yes",
                    CreatedDate = DateTime.Now,

                },
                new ProductClass()
                {
                    Id = 5,
                    Name = "Full Sleeve",
                    Description = "DescriptionDescriptionDescriptionDescriptionDescription",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2Fwirecutter%2Freviews%2Fbest-womens-jeans%2F&psig=AOvVaw2PH6U2O--nwn5xHN_obU74&ust=1709478919703000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCNjUha7v1YQDFQAAAAAdAAAAABAE",
                    occupancy = 1,
                    Price = "$500",
                    Amenity = "Yes",
                    CreatedDate = DateTime.Now,

                }
            );
        }
    }
}
