using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        [Display(Name = "Student ID")]
        public virtual int Id { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a Last Name.")]
        [StringLength(50, ErrorMessage = "Last name cannot be more than 50 characters.")]
        public virtual string LastName { get; set; }


        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a First Name.")]
        [StringLength(50, ErrorMessage = "First name cannot be more than 50 characters.")]
        public virtual string FirstName { get; set; }

        [Required]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }
        
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }
        
        [Display(Name = "Zip Code")]
        public string Zipcode { get; set; }
        [Required]
        public string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validate Address's are different
            if (Address2 == Address1)
            { 
                yield return (new ValidationResult("Address 2 cannot be the same as Address 1", new[] { "Address2"}));
            }

            //Validate length of state field
            
            if (State != null && State.Length != 2)
            {
                yield return (new ValidationResult("Enter a 2 digit State code", new[] { "State" }));                               
            }
            

            //Validate Zip Code
            if (Zipcode.Length != 5)
            {                
                yield return (new ValidationResult("Enter a 5 digit Zipcode", new[] { "Zipcode" }));                           
            }
        }
    }
}