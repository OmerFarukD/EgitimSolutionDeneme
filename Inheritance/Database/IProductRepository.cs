namespace Inheritance.Database;

public interface IProductRepository
{
    void Add(Product product);
    void GetAll();
    Product GetById(int id);
    void Delete(int id);
}