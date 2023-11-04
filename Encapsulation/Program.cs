using Encapsulation;

Book book = new Book();
Book1 book1 = new Book1(1,"kumarbaz","dostoyevski",30);
Book1 constructorBook = new Book1(name:"Ekmeğimi Kazanırken", price:30, id:2,author:"gorki");

// TODO: Class oluşturma çeşitleri

Book b = new Book();
var b1 = new Book();
Book b2 = new();


Console.WriteLine(constructorBook.ToString());


book.SetId(1);
book.SetName("Abasıyanık");
book.SetAuthor("sait faik");
book.SetPrice(25);

Console.WriteLine(book.ToString());
Console.WriteLine(book.GetAuthor());