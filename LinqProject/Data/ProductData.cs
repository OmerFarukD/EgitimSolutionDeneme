using LinqProject.Models;

namespace LinqProject.Data;

public class ProductData
{
    private List<Product> _products;

    public ProductData()
    {
        _products = new List<Product>()
        {
            new Product(){Id = 1,CategoryId = 1,ProductName = "Samsung M51",UnitPrice = 3000,UnitsInStock = 20},
            new Product(){Id = 2,CategoryId = 2,ProductName = "MSI BRAVO",UnitPrice = 30000,UnitsInStock = 20},
            new Product(){Id = 3,CategoryId = 1,ProductName = "Iphone 15",UnitPrice = 35000,UnitsInStock = 20},
            new Product(){Id = 4,CategoryId = 2,ProductName = "Monster Abra",UnitPrice = 25000,UnitsInStock = 20},
            new Product(){Id = 5,CategoryId = 3,ProductName = "JBL Kulaklık",UnitPrice = 1000,UnitsInStock = 20},
        };
    }

    public List<Product> GetAllProducts()
    {
        return _products;
    }
}