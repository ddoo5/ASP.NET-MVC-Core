using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1;

public class Structure2  //this is "различные Json структуры"
{
    [Key]
    [Column("userId")]
    public int userId { get; set; }
    
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("Title")]
    public string Title { get; set; }

    //Yep!
    [Column("Body")]
    public string Body { get; set; }
}