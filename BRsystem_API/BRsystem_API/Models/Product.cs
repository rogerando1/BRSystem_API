using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string ProductName { get; set; } = "";
    }
}
