using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int Id { get; set; }
        public virtual int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public virtual int CourseId { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        [RegularExpression("A-F")]
        public virtual string Grade { get; set; }
        public virtual bool IsActive { get; set; }
        [Required]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }
        [Required]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemster { get; set; }
        [Required]
        [Range(2018,2090)]
        [Display(Name ="Enrollment Year")]
        public virtual int EnrollmentYear { get; set; }
    }
}

