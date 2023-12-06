using IT3045C_Final.Controllers.models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace IT3045C_Final.Controllers.Data
{
    public class MetroCityData : DbContext
    {
        public MetroCityData(DbContextOptions<MetroCityData> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MetroCity>().HasData(new MetroCity { Id = 1, Location = "United States", Name = "New York City", Year = 1624, EstPop = "8.4m" },
            new MetroCity { Id = 1, Location = "Canada", Name = "Toronto", Year = 1793, EstPop = "2.9m" },
            new MetroCity { Id = 2, Location = "United Kingdom", Name = "London", Year = 43, EstPop = "8.9m" },
            new MetroCity { Id = 3, Location = "United Kingdom", Name = "Birmingham", Year = 1156, EstPop = "1.1m" },
            new MetroCity { Id = 4, Location = "United States", Name = "Los Angeles", Year = 1781, EstPop = "3.8m" },
            new MetroCity { Id = 5, Location = "Switzerland", Name = "Geneva", Year = 1541, EstPop = "198k" },
            new MetroCity { Id = 6, Location = "The Netherlands", Name = "Amsterdam", Year = 1275, EstPop = "821k" });


        }
        public DbSet<MetroCity> Information { get; set; }
    }
}