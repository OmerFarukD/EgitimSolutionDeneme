//TODO: Senaryo = Bir E ticaret sisteminde veritabanında CRUD operasyonları yapılması isteniyor gereken kodu yazınız.

using Inheritance;
using Inheritance.Database;

Product product = new Product()
{
    Id = 1,
    CategoryId = 1,
    ProductName = "Bilgisayar",
    UnitPrice = 12000,
    UnitsInStock = 25
};
Console.WriteLine(product.ToString());

// Polymorphism yapalım 
BaseEntity baseEntity = new Category()
{
    Id = 1,
    CategoryName = "Bilgisayar"
};
Console.WriteLine(baseEntity.ToString());

//Repository İşlemleri : 
//TODO: Ekleme operasyonları.
IProductRepository productRepository= new ProductRepository();
productRepository.Add(new Product(){Id = 10,CategoryId = 3,ProductName = "Kazak",UnitPrice = 250,UnitsInStock = 20});
productRepository.GetAll();