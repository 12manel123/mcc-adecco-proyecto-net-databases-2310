namespace EFC1.Models;
public class Book{//exactamenten el mismo name
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Isbn { get; set; }

}