using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class AddToCart
    {
        [Key]
        [Required]
        public int CartID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int quantity { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateOnly OrderDate { get; set; }

        [Column(TypeName = "Time")]
        [Required]
        public TimeOnly OrderTime { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Required]
        public int PartID { get; set; }

        [Required]
        public int InstructorID { get; set; }

        [Required]
        public int ReleaserID { get; set; }
       
        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; }   = new Student();

        [ForeignKey(nameof(PartID))]
        public Parts Parts { get; set; } = new Parts();

        [ForeignKey(nameof(InstructorID))]
        public Instructor Instructor { get; set;} = new Instructor();

        [ForeignKey(nameof(ReleaserID))]
        public Staff Staff { get; set; } = new Staff();
    }
}
