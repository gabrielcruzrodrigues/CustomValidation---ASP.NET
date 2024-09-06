using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Validations
{
    public class FirstWordUpperAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, 
            ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            var firstWord = value.ToString()[0].ToString();
            if (firstWord != firstWord.ToUpper())
            {
                return new ValidationResult("A primeira letra do nome do produto deve ser maiúscula.");
            }

            return ValidationResult.Success;
        }
    }
}
