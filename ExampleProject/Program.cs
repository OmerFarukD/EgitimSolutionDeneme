// See https://aka.ms/new-console-template for more information
// todo: Bir BookStore uygulamasında Kitap ve yazar tablosuyla alakalı işlemler isteniyor
//todo: 2 tablo için ekleme , listeleme vs gibi işlemler yapılması isteniyor.

using ExampleProject.Operations;
using ExampleProject.Operations.GenericOperations;
using ExampleProject.Tables;


// Inheritance
Author author = new Author()
{
    Id = 1,
    Name = "Ömer Seyfettin"
};

Book book = new Book()
{
    Id = 3,
    Price = 100,
    Stock = 20,
    Title = "Kaşağı"
};

Console.WriteLine(author.ToString());
Console.WriteLine(book.ToString());

// todo: Polymorphism
BaseTable book1 = new Book()
{
    Id = 2,
    Price = 20,
    Stock = 20,
    Title = "Nutuk"
};
Console.WriteLine(book1.ToString());
Console.WriteLine("--------------Kitap Operasyonları--------------");

IBookOperation bookOperation = new BookOperation();
IAuthorOperation authorOperation = new AuthorOperation();
bookOperation.Add(book);
Console.WriteLine("--------------Kitap Id--------------");
Console.WriteLine(bookOperation.GetById(3).ToString());

Console.WriteLine("--------------Yazar Operasyonları--------------");
authorOperation.Add(author);
Console.WriteLine("--------------Yazar Id--------------");
Console.WriteLine(authorOperation.GetById(2).ToString());


Console.WriteLine("--------------Jenerik Operasyonları--------------");
IGenericOperation<Book> genercBook= new GenericOperation<Book>();
IGenericOperation<Author> genericAuthor = new GenericOperation<Author>();
genercBook.Add(book);
genericAuthor.Add(author);

Console.WriteLine("--------------Yazar Id--------------");
Console.WriteLine(genericAuthor.GetById(1).ToString());
Console.WriteLine("--------------Kitap Id--------------");
Console.WriteLine(genercBook.GetById(3).ToString());
