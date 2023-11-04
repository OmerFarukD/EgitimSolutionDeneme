using System.Globalization;

namespace Encapsulation;


public class Book
{
    private int Id;
    private string? Name;
    private double Price;
    private string? Author;

    public int GetId()
    {
        return Id;
    }

    public void SetId(int id)
    {
        Id = id;
    }

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public double GetPrice()
    {
        return Price;
    }

    // TODO : Ürün Fiyatı bilgisi girildiği zaman KDV oranını da uygulasın.
    public void SetPrice(double price)
    {
        Price = price + price*0.08;
    }

    public string GetAuthor()
    {
        return Author;
    }

    //TODO: Yazar adı eklerken kullanıcı baş harflerini Küçük Harflerle girerse Büyük Harflerle yazsın.
    public void SetAuthor(string author)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string capitalizeAuthor = textInfo.ToTitleCase(author);
        
        Author = capitalizeAuthor;
    }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Author : {Author}, Price: {Price} ";
    }
}

