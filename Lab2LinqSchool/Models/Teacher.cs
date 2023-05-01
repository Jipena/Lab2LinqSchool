using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2LinqSchool.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; } = 0;
        [Required]
        [StringLength(maximumLength: 30)]
        [DisplayName("First Name")]
        public string TeacherFirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DisplayName("Last Name")]
        public string TeacherLastName { get; set; }
        [NotMapped]
        [ValidateNever]
        public virtual ICollection<Course> Courses { get; set; } // Navigation
    }
}
