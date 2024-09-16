using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BRsystem_API.Models
{
    public class Transaction
    {
        [Key]
        [Required]
        public int TransactionID { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Quantity { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateOnly OrderDate { get; set; }

        [Column(TypeName = "Time")]
        [Required]
        public TimeOnly OrderTime { get; set; }

        [Required]
        public int StudentID { get; set; }
      
        [Required]
        public int InstructorID { get; set; }
       
        [Required]
        public int ReleaserID { get; set; }
       
        [Required]
        public int PartID { get; set; }

        [ForeignKey(nameof(StudentID))]
        public Student Student { get; set; } = new Student();

        [ForeignKey(nameof(InstructorID))]
        public Instructor Instructor { get; set; } = new Instructor();

        [ForeignKey(nameof(ReleaserID))]
        public Staff Staff { get; set; } = new Staff();

        [ForeignKey(nameof(PartID))]
        public Parts Parts { get; set; } = new Parts();
    }
}
