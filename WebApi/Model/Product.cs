using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5)]
        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, 100000)]
        public double Price { get; set; }

        public bool Available { get; set; }

    }
}
