using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EnrollmentApplication.Models
{
    public class InvalidChars : ValidationAttribute
    {
        readonly string invChar;

        public InvalidChars(string invChar) : base("{0} contains unacceptable characters!")
        {
            this.invChar = invChar;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                foreach (char c in invChar)
                {
                    if(((string)value).Contains(c))
                        {
                            var errormessage = FormatErrorMessage(validationContext.DisplayName);
                            return new ValidationResult(errormessage);
                        }
                }
                
            }

            return ValidationResult.Success;    
        }
    }
}