using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class RequiredGreaterThanZero : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if ((int) value < 1 || (int) value == 0) {
                return new ValidationResult("Calorie count must be greater than 0.");
            }
            return ValidationResult.Success;
        }
    }
}