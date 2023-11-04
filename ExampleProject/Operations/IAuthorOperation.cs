using ExampleProject.Tables;

namespace ExampleProject.Operations;

public interface IAuthorOperation
{
    void Add(Author author);
    List<Author> GetAll();
    Author GetById(int id);
}