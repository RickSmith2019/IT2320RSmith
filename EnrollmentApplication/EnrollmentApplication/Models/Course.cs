using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int Id { get; set; }

        [Display(Name = "Course Title")]
        [Required(ErrorMessage = "Please enter a Couse Title.")]
        [StringLength(150, ErrorMessage = "The Course Title cannot be more than 150 characters")]
        public virtual string Title { get; set; }

        [Display(Name = "Description")]
        public virtual string Description { get; set; }

        [Display(Name = "Number of Credits")]
        [Required(ErrorMessage = "Please enter the number of credits.")]
        [Range(1, 4, ErrorMessage = "Enter a number between 1 and 4.")]
        public virtual float Credits { get; set; }

        [Display(Name = "Instructor Name")]
        public virtual string InstructorName { get; set; }
    }
}