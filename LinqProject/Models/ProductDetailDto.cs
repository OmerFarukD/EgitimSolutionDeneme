namespace LinqProject.Models;

public class ProductDetailDto
{
    public string? ProductName { get; set; }
    public string? CategoryName { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }

    public override string ToString()
    {
        return $"ProductName : {ProductName}, CategoryName: {CategoryName}, UnitPrice : {UnitPrice}, UnitsInStock : {UnitsInStock}";
    }
}