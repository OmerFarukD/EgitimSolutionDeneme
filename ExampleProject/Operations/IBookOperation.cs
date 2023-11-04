using ExampleProject.Tables;

namespace ExampleProject.Operations;

public interface IBookOperation
{
    void Add(Book book);
    List<Book> GetAll();
    Book GetById(int id);
}