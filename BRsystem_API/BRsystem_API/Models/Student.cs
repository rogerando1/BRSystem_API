using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BRsystem_API.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentID { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Fname { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Mname { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Lname { get; set; } = "";

        [Column(TypeName = "int")]
        [Required]
        public int Age { get; set; }

        [Column(TypeName = "varchar(6)")]
        [Required]
        public string Gender { get; set; } = "";

        [Column(TypeName = "Date")]
        [Required]
        public DateOnly Bday { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int YearLevel { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Program { get; set; } = "";

    }
}
