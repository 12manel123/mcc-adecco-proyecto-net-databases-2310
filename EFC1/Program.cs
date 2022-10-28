using EFC1.Models;

Console.WriteLine("Hello, World!");

/*var factory = new AppDbContextFactory();
var context = factory.CreateDbContext(null);*/

/*Book book1 = new Book { Id = 1, Isbn = "123456ER", Title = "DonKijte", Description = "description" };
Method8_Update2(book1);*/
Method12_FindByTitle();


void Method1_Add() {
    Console.WriteLine("================================= GUARDAR UNO ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book1 = new Book { Isbn = "123456ER", Title = "DOnKijte", Description = "description" };
    Book book2 = new Book { Isbn = "9876544ER", Title = "Santmari", ReleaseYear = 2006, Description = "description" };

    context.Books.Add(book1);
    context.Books.Add(book2);

    context.SaveChanges();
    Console.WriteLine(book1);
    Console.WriteLine(book2);
}

void Method2_AddRange() {
    Console.WriteLine("================================= GUARDAR VARIOS ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book3 = new Book { Isbn = "2353242R", Title = "book3", ReleaseYear = 2006, Description = "description" };
    Book book4 = new Book { Isbn = "357534V", Title = "book4", ReleaseYear = 2006, Description = "description" };
    var books = new List<Book> { book3, book4 };

    context.Books.AddRange(books);

    context.SaveChanges();

    Console.WriteLine(book3);
    Console.WriteLine(book4);
}

void Method3_ValidacionesTitle_MinLength() {
    Console.WriteLine("================================= VALIDACIONES TITLE MIN LENGTH ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book1 = new Book { Isbn = "666666", Title = "hol", ReleaseYear = 2006, Description = "description6" };
    context.Books.Add(book1);
    context.SaveChanges();
    Console.WriteLine(book1);
}

void Method4_ValidacionesTitle_MaxLength() {
    Console.WriteLine("================================= VALIDACIONES TITLE MAX LENGTH====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book1 = new Book { Isbn = "666666", Title = "howwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwl", ReleaseYear = 2006, Description = "description6" };
    context.Books.Add(book1);
    context.SaveChanges();
    Console.WriteLine(book1);
}

void Method5_First() {
    Console.WriteLine("================================= FIRST ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book = context.Books.First();
    Console.WriteLine(book);
}

void Method6_Find(int id) {
    Console.WriteLine("================================= FIND ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    Book book = context.Books.Find(id);
    Console.WriteLine(book);
}

void Method7_Count() {
    Console.WriteLine("================================= COUNT ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    int TotalBooks = context.Books.Count();
    Console.WriteLine(TotalBooks);
}

void Method8_Update() {
    Console.WriteLine("================================= UPDATE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book = context.Books.Find(1);
    book.Description = "NewDesc";


    context.Books.Update(book);
    context.SaveChanges();
    Console.WriteLine(book);
}

void Method8_Update2(Book book) {
    Console.WriteLine("================================= UPDATE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    context.Books.Update(book);
    context.SaveChanges();
    Console.WriteLine(book);
}

void Method9_UpdateRange() {
    Console.WriteLine("================================= UPDATE RANGE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = context.Books.Find(1);
    book1.Description = "NewDesc";
    Book book2 = context.Books.Find(2);
    book2.Description = "TestDesc";


    context.Books.UpdateRange(book1,book2);
    context.SaveChanges();
    Console.WriteLine(book1+" test "+book2);

}

void Method9_UpdateRange2() {
    Console.WriteLine("================================= UPDATE RANGE 2 ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = new Book { Id=1,Isbn = "123456ER", Title = "DOnKijte", Description = "description" };
    Book book2 = new Book { Id = 2, Isbn = "9876544ER", Title = "Santmari", ReleaseYear = 2006, Description = "description" };
    var books = new List<Book> { book1, book2 };

    context.Books.UpdateRange(books);
    context.SaveChanges();
}

void Method10_Remove() {
    Console.WriteLine("================================= REMOVE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    int before = context.Books.Count();
    Book book1 = context.Books.Find(1);
    context.Books.Remove(book1);
    context.SaveChanges();
    int after = context.Books.Count();
    if (after == before - 1) { Console.WriteLine("Se ha borrado 1 libro"); }
}

void Method11_RemoveRange() {
    Console.WriteLine("================================= REMOVE RANGE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = context.Books.Find(2);
    Book book2 = context.Books.Find(3);

    context.Books.RemoveRange(book1,book2);
    context.SaveChanges();
    Console.WriteLine("Eliminado: " + book1+" y "+book2);
}

void Method11_RemoveRange2() {
    Console.WriteLine("================================= REMOVE RANGE 2 ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);

    Book book1 = context.Books.Find(2);
    Book book2 = context.Books.Find(3);
    var books = new List<Book> { book1, book2 };

    context.Books.RemoveRange(books);
    context.SaveChanges();
    Console.WriteLine("Libros Eliminados");
}

void Method12_FindByTitle() {
    Console.WriteLine("================================= FIND BY TITLE ====================");
    AppDbContext context = new AppDbContextFactory().CreateDbContext(null);
    List<Book>books = context.Books.Where(book => book.Title == "Santmari").ToList();

    foreach (var item in books) {
        Console.WriteLine(item);
    }

    //var books2 = from book in context.Books where book.Title.ToLower().Equals("Santmari") select book;//otra manera de filtrar mas complicada

}