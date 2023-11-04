namespace LinqAdvanced.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int  Stock { get; set; }
    public int CategoryId { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Price : {Price}, Stock : {Stock}, CategoryId : {CategoryId}";
    }
}