namespace LinqProject.Models;

public class Product :Comparer<Product>
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int  CategoryId { get; set; }

    public decimal UnitPrice { get; set; }

    public int UnitsInStock  { get; set; }


    public override string ToString()
    {
        return $"Id : {Id}, CategoryId: {CategoryId}, Name: {ProductName}, UnitPrice : {UnitPrice}, UnitsInStock: {UnitsInStock}";
    }

    public override int Compare(Product? x, Product? y)
    {
        if (x.UnitPrice>y.UnitPrice)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}