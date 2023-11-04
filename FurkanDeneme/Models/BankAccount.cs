namespace FurkanDeneme.Models;

public class BankAccount
{
    public string? CustomerName { get; set; }
    public string? Iban { get; set; }
    public CustomerType CustomerType { get; set; }
    public double? Budget { get; set; }
    
    
    
    public override string ToString()
    {
        return $"Müşteri  Adı :{CustomerName}, Bakiye : {Budget} ";
    }
}