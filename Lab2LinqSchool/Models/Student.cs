using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab2LinqSchool.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; } = 0;
        [Required]
        [StringLength(maximumLength: 30)]
        [DisplayName("First Name")]
        public string StudentFirstName { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DisplayName("Last Name")]
        public string StudentLastName { get; set; }

        [ForeignKey("Classes")]
        public int ClassId { get; set; }
        [ValidateNever]
        public virtual Class Classes { get; set; }
    }
}
