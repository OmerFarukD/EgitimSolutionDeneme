using ExampleProject.Tables;

namespace ExampleProject.Operations;

public class BookOperation : IBookOperation
{
    private List<Book> _list;

    public BookOperation()
    {
        _list = new List<Book>()
        {
            new Book(){Id = 1,Price = 20,Stock = 10,Title = "Nutuk"}
        };
    }

    public void Add(Book book)
    {
        _list.Add(book);
        _list.ForEach(x=> Console.WriteLine(x.ToString()));
    }

    public List<Book> GetAll()
    {
        return _list;
    }

    public Book GetById(int id)
    {
        Book filterBook = new Book();
        
        foreach (var book in _list)
        {
            if (book.Id == id)
            {
                filterBook= book;
            }
        }
        return filterBook;
    }
}