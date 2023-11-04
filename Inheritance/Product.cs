namespace Inheritance;

public class Product : BaseEntity
{
    public int CategoryId { get; set; }
    public string? ProductName { get; set; }
    public double UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, CategoryId: {CategoryId}, ProductName : {ProductName}, UnitPrice : {UnitPrice}, UnitsInStock : {UnitsInStock}";
    }

   
}