using IT3045C_Final.Controllers.models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers.Data
{
    public class GenInfoData : DbContext
    {
        public GenInfoData(DbContextOptions<GenInfoData> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GenInfo>().HasData(new GenInfo { Id = 1, Name = "Nick Bernloehr", Birthdate = new DateTime(1998, 9, 19), Program = "CyberSecurity", Year = "Sophmore" },
            new GenInfo { Id = 2, Name = "Jeremiah Fowler", Birthdate = new DateTime(1998, 9, 19), Program = "CyberSecurity", Year = "Sophmore" },
            new GenInfo { Id = 3, Name = "Arian Tousi Kharazmi", Birthdate = new DateTime(1998, 9, 19), Program = "CyberSecurity", Year = "Sophmore" },
            new GenInfo { Id = 4, Name = "Connor Kavanaugh", Birthdate = new DateTime(1998, 9, 19), Program = "CyberSecurity", Year = "Sophmore" });

        }
        public DbSet<GenInfo> Information { get; set; }
    }
}
