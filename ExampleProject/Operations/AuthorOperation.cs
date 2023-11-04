using ExampleProject.Tables;

namespace ExampleProject.Operations;

public class AuthorOperation : IAuthorOperation
{
    private List<Author> _list;

    public AuthorOperation()
    {
        _list = new List<Author>()
        {
            new Author(){Id = 2,Name = "Mehmet Akif Ersoy"}
        };
    }

    public void Add(Author book)
    {
        _list.Add(book);
        _list.ForEach(x=> Console.WriteLine(x.ToString()));
    }

    public List<Author> GetAll()
    {
        return _list;
    }

    public Author GetById(int id)
    {
        Author filterAuthor = new Author();
        
        foreach (var author in _list)
        {
            if (author.Id == id)
            {
                filterAuthor= author;
            }
        }
        return filterAuthor;
    }
}