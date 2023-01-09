namespace _00_WebApi_With_Database.Models.Entities
{
    public class CaseEntity
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Modified { get; set; } = DateTime.Now;
        
        public int StatusId { get; set; }
        public StatusEntity Status { get; set; } = null!;

    }
}
