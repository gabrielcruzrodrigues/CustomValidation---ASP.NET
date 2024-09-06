using CustomValidation.Validations;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Domains
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [FirstWordUpper]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
