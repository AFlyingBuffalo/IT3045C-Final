using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers.models
{
    public class MetroCity
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string EstPop { get; set; }
    }
}