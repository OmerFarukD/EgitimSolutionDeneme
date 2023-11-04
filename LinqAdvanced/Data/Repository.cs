using LinqAdvanced.Models;

namespace LinqAdvanced.Data;

public class Repository
{
    public static List<Product> Products { get; set; } = new List<Product>()
    {
        new Product(){Id = 1,CategoryId = 1,Name = "Msi Laptop",Price = 35000,Stock = 125},
        new Product(){Id = 2,CategoryId = 1,Name = "Monster Laptop",Price = 27000,Stock = 21},
        new Product(){Id = 3,CategoryId = 1,Name = "Hp Laptop",Price = 25000,Stock = 12},
        new Product(){Id = 4,CategoryId = 2,Name = "Samsung Telefon",Price = 20000,Stock = 23},
        new Product(){Id = 5,CategoryId = 2,Name = "Apple Telefon",Price = 55000,Stock = 34},
        new Product(){Id = 6,CategoryId = 2,Name = "LG telefon",Price = 15000,Stock = 45},
        new Product(){Id = 7,CategoryId = 3,Name = "Samsung Monitor",Price = 5000,Stock = 67},
        new Product(){Id = 8,CategoryId = 3,Name = "Asus Monitor",Price = 4000,Stock = 78},
        new Product(){Id = 9,CategoryId = 3,Name = "Msi Monitor",Price = 8000,Stock = 89},
        new Product(){Id = 10,CategoryId = 1,Name = "Asus Laptop",Price = 25000,Stock = 90},
        new Product(){Id = 11,CategoryId = 2,Name = "Huawei Telefon",Price = 9000,Stock = 11},
        new Product(){Id = 12,CategoryId = 3,Name = "Casper Monitor",Price = 4000,Stock = 25},
    };

    public static List<Category> Categories { get; set; } = new List<Category>()
    {
        new Category(){Id = 1,Name = "Bilgisayar"},
        new Category(){Id = 2,Name = "Telefon"},
        new Category(){Id = 3,Name = "Monitor"}
        
    };

}