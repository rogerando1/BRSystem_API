using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class CourseTime
    {
        [Key]
        [Required]
        public int CourseTimeID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string StartTime { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string EndTime { get; set; } = "";

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Section { get; set; } = "";

        [Required]
        public int InstructorID { get; set; }

        [Required]
        public int CourseID { get; set; }

        [ForeignKey(nameof(InstructorID))]
        public Instructor Instructor { get; set; } = new Instructor();

        [ForeignKey(nameof(CourseID))]
        public Courses Courses { get; set; } = new Courses();
    }
}
