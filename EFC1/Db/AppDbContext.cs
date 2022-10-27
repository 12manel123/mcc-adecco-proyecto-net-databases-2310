namespace EFC1.Db;
public class AppDbContext : DbContext{

    public DbSet<Book> Books { get; set; }//Agregar un DbSet por cada clase en Models que tengamos
    public AppDbContext(DbContextOptions options) : base(options) {
    }
}

