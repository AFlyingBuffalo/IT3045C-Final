using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers.models
{
    public class NHLTeams
    {
        public int Id { get; set; }
        public string Loc { get; set; }
        public string Name { get; set; }
        public int YearEstd { get; set; }
        public string AHLLoc { get; set; }
        public string ECHLLoc { get; set; }
    }
}