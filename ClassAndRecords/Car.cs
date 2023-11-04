namespace ClassAndRecords;

public class Car 
{
    public Car()
    {
        
    }
    public Car(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; init; }
    public decimal Price { get; init; }
}