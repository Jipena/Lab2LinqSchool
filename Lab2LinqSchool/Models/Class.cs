using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2LinqSchool.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; } = 0;
        [DisplayName("Class Name")]
        public string ClassName { get; set; }
        [NotMapped]
        [ValidateNever]
        public virtual ICollection<Course> Courses { get; set; } // Navigation
    }
}
