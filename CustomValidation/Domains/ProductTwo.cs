using CustomValidation.Validations;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Domains
{
    public class ProductTwo : IValidatableObject
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [FirstWordUpper]
        public string? Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                var firstWord = this.Name[0].ToString();
                if (firstWord != firstWord.ToUpper())
                {
                    yield return new ValidationResult("A primeira letra do produto deve ser maiúscula", new[]
                    {
                         nameof(this.Name)
                    });
                }
            }

            if (this.Price <= 0)
            {
                yield return new ValidationResult("O preço não pode ser menor que R$ 0,00", new[]
                {
                    nameof(this.Price)
                });
            }
        }
    }
}
