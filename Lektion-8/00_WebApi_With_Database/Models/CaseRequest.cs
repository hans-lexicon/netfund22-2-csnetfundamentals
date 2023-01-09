using _00_WebApi_With_Database.Models.Entities;

namespace _00_WebApi_With_Database.Models
{
    public class CaseRequest
    {
        public string Email { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
