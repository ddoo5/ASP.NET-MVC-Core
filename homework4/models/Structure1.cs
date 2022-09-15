using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1;

public class Structure1   //this is "различные Json структуры"
{
    //вот так красиво
    [Key]
    [Column("userId")]
    public int userId { get; set; }
    
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("Title")]
    public string Title { get; set; }
    
    //different structures?
    [Column("Body")]
    public string Completed { get; set; }
}