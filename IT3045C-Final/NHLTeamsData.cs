using IT3045C_Final.Controllers.models;
using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers.Data
{
    public class NHLTeamsData : DbContext
    {
        public NHLTeamsData(DbContextOptions<NHLTeamsData> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<NHLTeams>().HasData(new NHLTeams { Id = 1, Loc = "Montreal", Name = "Canadiens", YearEstd = 1909, AHLLoc = "Laval", ECHLLoc = "Trois-Rivieres" },
            new NHLTeams { Id = 2, Loc = "Toronto", Name = "Maple Leafs", YearEstd = 1917, AHLLoc = "Toronto", ECHLLoc = "Newfoundland" },
            new NHLTeams { Id = 3, Loc = "Boston", Name = "Bruins", YearEstd = 1924, AHLLoc = "Providence", ECHLLoc = "Maine" },
            new NHLTeams { Id = 4, Loc = "Chicago", Name = "Blackhawks", YearEstd = 1926, AHLLoc = "Rockford", ECHLLoc = "Indy" },
            new NHLTeams { Id = 5, Loc = "Detroit", Name = "Red Wings", YearEstd = 1926, AHLLoc = "Grand Rapids", ECHLLoc = "Toledo" },
            new NHLTeams { Id = 6, Loc = "New York", Name = "Rangers", YearEstd = 1926, AHLLoc = "Hartford", ECHLLoc = "Cincinnati" },
            new NHLTeams { Id = 7, Loc = "Vancouver", Name = "Canucks", YearEstd = 1945, AHLLoc = "Abbotsford", ECHLLoc = "Kalamazoo" },
            new NHLTeams { Id = 8, Loc = "Dallas", Name = "Stars", YearEstd = 1967, AHLLoc = "Texas", ECHLLoc = "Idaho" },
            new NHLTeams { Id = 9, Loc = "Los Angeles", Name = "Kings", YearEstd = 1967, AHLLoc = "Ontario", ECHLLoc = "Greenville" },
            new NHLTeams { Id = 10, Loc = "Philadelphia", Name = "Flyers", YearEstd = 1967, AHLLoc = "Lehigh Valley", ECHLLoc = "Reading" },
            new NHLTeams { Id = 11, Loc = "Pittsburgh", Name = "Penguins", YearEstd = 1967, AHLLoc = "Wilkes-Barre/Scranton", ECHLLoc = "Wheeling" },
            new NHLTeams { Id = 12, Loc = "St. Louis", Name = "Blues", YearEstd = 1967, AHLLoc = "Springfield", ECHLLoc = "" },
            new NHLTeams { Id = 13, Loc = "Buffalo", Name = "Sabres", YearEstd = 1970, AHLLoc = "Rochester", ECHLLoc = "Jacksonville" },
            new NHLTeams { Id = 14, Loc = "Arizona", Name = "Coyotes", YearEstd = 1972, AHLLoc = "Tucson", ECHLLoc = "" },
            new NHLTeams { Id = 15, Loc = "Calgary", Name = "Flames", YearEstd = 1972, AHLLoc = "Calgary", ECHLLoc = "Rapid City" },
            new NHLTeams { Id = 16, Loc = "Carolina", Name = "Hurricanes", YearEstd = 1972, AHLLoc = "", ECHLLoc = "Norfolk" },
            new NHLTeams { Id = 17, Loc = "Colorado", Name = "Avalanche", YearEstd = 1972, AHLLoc = "Colorado", ECHLLoc = "Utah" },
            new NHLTeams { Id = 18, Loc = "Edmonton", Name = "Oilers", YearEstd = 1972, AHLLoc = "Bakersfield", ECHLLoc = "Fort Wayne" },
            new NHLTeams { Id = 19, Loc = "New York", Name = "Islanders", YearEstd = 1972, AHLLoc = "Bridgeport", ECHLLoc = "Worcester" },
            new NHLTeams { Id = 20, Loc = "New Jersey", Name = "Devils", YearEstd = 1974, AHLLoc = "Utica", ECHLLoc = "Adirondack" },
            new NHLTeams { Id = 21, Loc = "Washington", Name = "Capitals", YearEstd = 1974, AHLLoc = "Hershey", ECHLLoc = "South Carolina" },
            new NHLTeams { Id = 22, Loc = "San Jose", Name = "Sharks", YearEstd = 1991, AHLLoc = "San Jose", ECHLLoc = "Wichita" },
            new NHLTeams { Id = 23, Loc = "Ottawa", Name = "Senators", YearEstd = 1992, AHLLoc = "Belleville", ECHLLoc = "Allen" },
            new NHLTeams { Id = 24, Loc = "Tampa Bay", Name = "Lightning", YearEstd = 1992, AHLLoc = "Syracuse", ECHLLoc = "Orlando" },
            new NHLTeams { Id = 25, Loc = "Anaheim", Name = "Ducks", YearEstd = 1993, AHLLoc = "San Diego", ECHLLoc = "Tulsa" },
            new NHLTeams { Id = 26, Loc = "Florida", Name = "Panthers", YearEstd = 1993, AHLLoc = "Charlotte", ECHLLoc = "Florida" },
            new NHLTeams { Id = 27, Loc = "Nashville", Name = "Predators", YearEstd = 1998, AHLLoc = "Milwaukee", ECHLLoc = "Atlanta" },
            new NHLTeams { Id = 28, Loc = "Winnipeg", Name = "Jets", YearEstd = 1999, AHLLoc = "Manitoba", ECHLLoc = "Norfolk" },
            new NHLTeams { Id = 29, Loc = "Columbus", Name = "Blue Jackets", YearEstd = 2000, AHLLoc = "Cleveland", ECHLLoc = "" },
            new NHLTeams { Id = 30, Loc = "Minnesota", Name = "Wild", YearEstd = 2000, AHLLoc = "Iowa", ECHLLoc = "Iowa" },
            new NHLTeams { Id = 31, Loc = "Vegas", Name = "Golden Knights", YearEstd = 2017, AHLLoc = "Henderson", ECHLLoc = "Savannah" },
            new NHLTeams { Id = 32, Loc = "Seattle", Name = "Kraken", YearEstd = 2021, AHLLoc = "Coachella Valley", ECHLLoc = "Kansas City" });

        }
        public DbSet<NHLTeams> Information { get; set; }
    }
}
