namespace ExampleProject.Tables;

public class Book : BaseTable
{
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Başlık: {Title}, Değeri : {Price}, Stok adedi: {Stock}";
    }
    
    
}