Console.WriteLine("Hello, World!");

/*var factory = new AppDbContextFactory();
var context = factory.CreateDbContext(null);*/
var context = new AppDbContextFactory().CreateDbContext(null);

Console.WriteLine("================================= GUARDAR UNO ====================");
Book book1 = new Book { Isbn = "123456ER", Title = "DOnKijte de la Almeria" };
Book book2 = new Book { Isbn = "9876544ER", Title = "Santmaria de la coloma" };

context.Books.Add(book1);
context.Books.Add(book2);

context.SaveChanges();
Console.WriteLine(book1);
Console.WriteLine(book2);


Console.WriteLine("================================= GUARDAR VARIOS ====================");
Book book3 = new Book { Isbn = "2353242R", Title = "book3" };
Book book4 = new Book { Isbn = "357534V", Title = "book4" };
var books = new List<Book> { book3,book4};

context.Books.AddRange(books);

context.SaveChanges();

Console.WriteLine(book3);
Console.WriteLine(book4);