using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class Staff
    {
        [Key]
        [Required]
        public int StaffID { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Fname { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Mname { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Lname { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Position { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Username { get; set; } = "";

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Password { get; set; } = "";

    }
}
