using System.ComponentModel.DataAnnotations;

namespace WinFormLearn.Entities
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
