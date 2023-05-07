namespace AEZ.Data;

using Areas.Identity.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Account
{

    [Key]
    public int Id { get; set; }

    public string AccountNumber { get; set; }

    [Column(TypeName = "nvarchar(10)")]
    public string Type { get; set; } = "Normal";

    //Methods I wish
    //

    public string ApplicationUserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public ICollection<Transaction> Transactions { get; set; }

}
