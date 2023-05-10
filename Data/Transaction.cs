namespace AEZ.Data;

using Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Transaction
{

    [Key]
    public int TransactionId { get; set; }

    public decimal Amount { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string? Note { get; set; }

    public DateTime Date { get; set; } = DateTime.Now;


    public int AccountId { get; set; }
    public Account Account { get; set; }
}
