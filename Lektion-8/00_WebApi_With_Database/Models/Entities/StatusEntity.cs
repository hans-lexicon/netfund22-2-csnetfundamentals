namespace _00_WebApi_With_Database.Models.Entities
{
    public class StatusEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<CaseEntity> Cases { get; set; } = null!;
    }


}
