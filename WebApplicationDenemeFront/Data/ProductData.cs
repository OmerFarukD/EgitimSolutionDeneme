using WebApplicationDenemeFront.Models;

namespace WebApplicationDenemeFront.Data;

public class ProductData
{
    private readonly List<Product?> _products;

    public ProductData()
    {
        _products = new()
        {
            new Product()
            {
                Id = 1,
                Name = "Msi Bilgisayar",
                Price = 10000
            },
            new Product()
            {
                Id = 2,
                Name = "Monster Bilgisayar",
                Price = 7500
            },
            new Product()
            {
                Id = 3,
                Name = "Apple Bilgisayar",
                Price = 50000
            }
        };
    }

    public void Add(Product? product)
    {
        _products.Add(product);
    }

    public List<Product?> GetAll()
    {
        return _products;
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(x => x.Id == id);
    }


}