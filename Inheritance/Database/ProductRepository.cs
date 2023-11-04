namespace Inheritance.Database;

public class ProductRepository : IProductRepository
{
    private List<Product> _products;

    public ProductRepository()
    {
        _products = new List<Product>()
        {
            new Product(){Id = 1,CategoryId = 1,ProductName = "Monster Abra", UnitPrice = 25000,UnitsInStock = 25},
            new Product(){Id = 2,CategoryId = 2,ProductName = "Samsung M51", UnitPrice = 15000,UnitsInStock = 25},
            new Product(){Id = 3,CategoryId = 2,ProductName = "Iphone 14 Pro Max", UnitPrice = 25000,UnitsInStock = 25},
            new Product(){Id = 4,CategoryId = 3,ProductName = "T-Shirt", UnitPrice = 1000,UnitsInStock = 25},
            new Product(){Id = 5,CategoryId = 3,ProductName = "Pantolon", UnitPrice = 2000,UnitsInStock = 25},
        };
    }

    public void Add(Product product)
    {
        _products.Add(product);
        GetAll();
    }

    public void GetAll()
    {
        foreach (var product in _products)
        {
            Console.WriteLine(product.ToString());
        }
    }

    public Product GetById(int id)
    {
        foreach (var product in _products)
        {
            if (product.Id==id)
            {
                return product;
            }   
        }

        throw new Exception($"Id : {id} ye sahip ürün bulunamadı.");
    }

    public void Delete(int id)
    {
        foreach (var product in _products)
        {
            if (product.Id==id)
            {
                _products.Remove(product);
            }   
        }
    }
}