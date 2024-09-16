using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class Parts
    {
        [Key]
        [Required]
        public int PartID { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string PartName { get; set; } = "";

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string PartDescription { get; set; } = "";

        [Column(TypeName = "int")]
        [Required]
        public int quantity { get; set; }

        [Required]
        public int ProductID { get; set; }

        [ForeignKey(nameof(ProductID))]
        public Product Product { get; set; } = new Product();
    }
}
