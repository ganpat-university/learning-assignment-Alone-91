using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short SubjectId { get; set; }

        [Display(Name = "Subject Name")]
        [Required]
        public string SubjectName { get; set; }

        

        #region Navigation Properties to the Department Model

        [Display(Name ="Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]
        public int DepartmentId { get; set; }


        [Display(Name ="Department Name")]
        public Department Department { get; set; }

        #endregion

    }
}
