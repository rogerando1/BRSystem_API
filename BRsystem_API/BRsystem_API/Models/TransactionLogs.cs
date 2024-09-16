using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BRsystem_API.Models
{
    public class TransactionLogs
    {
        [Key]
        [Required]
        public int TransactionLogsID { get; set; }

        [Column(TypeName = "Date")]
        [Required]
        public DateOnly ReturnDate { get; set; }

        [Column(TypeName = "Time")]
        [Required]
        public TimeOnly ReturnTime { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string Notes { get; set; } = "";

        [Required]
        public int TransactionID { get; set; }

        [Required]
        public int ReceiverID {  get; set; }

        [ForeignKey(nameof(TransactionID))]
        public Transaction Transaction { get; set; } = new Transaction();

        [ForeignKey(nameof(ReceiverID))]
        public Staff Staff { get; set; } = new Staff();


    }
}
