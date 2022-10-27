using System.ComponentModel.DataAnnotations.Schema;

namespace EFC1.Models;
public class Book {//exactamente el mismo name
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="Titulo obligatorio"),Column("title"),
        MinLength(5,ErrorMessage ="El titulo deve ser mayor de 5 caracteres"),
        MaxLength(15,ErrorMessage ="El titulo deve ser menor de 50 catacteres")]
    public string Title { get; set; }

    [Required, Column("isbn"), MaxLength(15, ErrorMessage = "El titulo deve ser menor de 50 catacteres")]
    public string Isbn { get; set; }

    [Required, Column("release_year")]
    public int ReleaseYear { get; set; }
    public override string ToString() {
        return $"Book: {Id}, Title:{Title}, Isbn:{Isbn}, Year:{ReleaseYear}";
    }


}