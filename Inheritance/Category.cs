namespace Inheritance;

public class Category : BaseEntity
{
  
    public string? CategoryName { get; set; }
    public override string ToString()
    {
        return $"Id : {Id}, CategoryName : {CategoryName}";
    }
}


//Id = 1 , Bilgisayar 
//Id=2, Ürün Adı : Asus, Ürün Değeri : 12000TL, Ürün Stoğu=20, KategoriId=1 