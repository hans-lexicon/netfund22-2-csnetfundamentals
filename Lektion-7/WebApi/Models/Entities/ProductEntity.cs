using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models.Entities
{
    public class ProductEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Title { get; set; } = null!;

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Category { get; set; } = null!;

        [Required]
        public string ImageName { get; set; } = null!;

        public int? Rating { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
