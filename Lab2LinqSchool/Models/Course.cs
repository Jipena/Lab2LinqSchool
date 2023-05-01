using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2LinqSchool.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; } = 0;
        [DisplayName("Course Name")]
        public string CourseName { get; set; }


        //[NotMapped]
        //[ValidateNever]
        [ForeignKey("Teachers")]
        public int TeacherId { get; set; }
        [ValidateNever]
        public virtual Teacher Teachers { get; set; }


        //[NotMapped]
        //[ValidateNever]
        [ForeignKey("Class")]
        public int ClassId { get; set; }
        [ValidateNever]
        public virtual Class Classes { get; set; }
    }
}
