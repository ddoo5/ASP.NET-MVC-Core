using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.DB.Models;

[Table("Buyers",Schema = "Work")]
public sealed class Buyer : NamedEntity
{
    [Column( "surname")]
    public string? LastName { get; set; }

    [Column("patronymic")]
    public string? Patronymic { get; set; }

    [Column("birthday_date")]
    public DateTime Birthday { get; set; }
}