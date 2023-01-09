using _00_WebApi_With_Database.Models.Entities;

namespace _00_WebApi_With_Database.Models
{
    public class Case
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Status { get; set; } = null!;
    }
}
