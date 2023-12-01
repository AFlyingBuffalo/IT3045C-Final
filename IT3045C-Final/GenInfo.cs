using Microsoft.EntityFrameworkCore;

namespace IT3045C_Final.Controllers.models
{
    public class GenInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Program { get; set; }
        public string Year { get; set; }
    }
}
