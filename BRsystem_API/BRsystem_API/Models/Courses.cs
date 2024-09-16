using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class Courses
    {
        [Key]
        [Required]
        public int CourseID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string CourseName { get; set; } = "";
    }
}
