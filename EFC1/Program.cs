using EFC1.Models;

Console.WriteLine("Hello, World!");

/*var factory = new AppDbContextFactory();
var context = factory.CreateDbContext(null);*/
var context = new AppDbContextFactory().CreateDbContext(null);

Method3_ValidacionesTitle();

void Method1_Add() {
    Console.WriteLine("================================= GUARDAR UNO ====================");
    Book book1 = new Book { Isbn = "123456ER", Title = "DOnKijte de la Almeria", ReleaseYear = 2006, Description = "description" };
    Book book2 = new Book { Isbn = "9876544ER", Title = "Santmaria de la coloma", ReleaseYear = 2006, Description = "description" };

    context.Books.Add(book1);
    context.Books.Add(book2);

    context.SaveChanges();
    Console.WriteLine(book1);
    Console.WriteLine(book2);
}

void Method2_AddRange() {
    Console.WriteLine("================================= GUARDAR VARIOS ====================");
    Book book3 = new Book { Isbn = "2353242R", Title = "book3", ReleaseYear = 2006, Description = "description" };
    Book book4 = new Book { Isbn = "357534V", Title = "book4", ReleaseYear = 2006, Description = "description" };
    var books = new List<Book> { book3, book4 };

    context.Books.AddRange(books);

    context.SaveChanges();

    Console.WriteLine(book3);
    Console.WriteLine(book4);
}

void Method3_ValidacionesTitle() {
    Console.WriteLine("================================= VALIDACIONES TITLE ====================");
    Book book1 = new Book { Isbn = "666666", Title = "Book6", ReleaseYear = 2006, Description = "description6" };
    context.Books.Add(book1);
    context.SaveChanges();
    Console.WriteLine(book1);
}


