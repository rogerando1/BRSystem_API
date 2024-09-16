using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BRsystem_API.Models
{
    public class Instructor
    {
        [Key]
        [Required]
        public int InstructorId { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string InstructorName { get; set; } = "";

    }
}
