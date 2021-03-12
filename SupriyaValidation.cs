using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3
{
    public class SupriyaValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                if (value.ToString().Contains("supriya"))
                {
                    return ValidationResult.Success;
                }
            }
            ErrorMessage = ErrorMessage ?? validationContext.DisplayName+ " the field does not contain supriya ";
            return new ValidationResult(ErrorMessage);
        }
    }
}