using System.ComponentModel.DataAnnotations;

namespace EFCoreAssignment.Models
{
    public class Validation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
                    int year = Convert.ToDateTime(value).Year;
                    if (year >= 2002 && year <= 2005)
                    {
                        return ValidationResult.Success;
                    }                    
            }
            return new ValidationResult(ErrorMessage ?? "Date of birth year should between 2002 to 2005");
        }

    }
    public class DateOFJoiningValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
               DateTime ? dateTime=(DateTime ?)value;
                if ((dateTime<=DateTime.Now))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Date of joining  should between less than current date");
        }
    }

    public class DeptValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {

            if (value != null)
            {
                string? dept=(string?)value;
                if(dept=="HR"|| dept=="Accts")
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(ErrorMessage ?? "Dept should be HR or Account");
        }
    }

}
