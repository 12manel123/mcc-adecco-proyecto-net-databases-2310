namespace EFC1.Db;
public class AppDbContext : DbContext{

    public DbSet<Book> Books { get; set; }//Agregar un DbSet por cada clase en Models que tengamos
    public DbSet<Author> Authors { get; set; }//Agregar un DbSet por cada clase en Models que tengamos

    public AppDbContext(DbContextOptions options) : base(options) {
    }

    //Configurar columans a nivel gloval
   /* protected override void ConfigureConventions(ModelConfigurationBuilder confBuilder) {
        confBuilder.Properties<string>().HaveMaxLength(100);
    }*/
}

