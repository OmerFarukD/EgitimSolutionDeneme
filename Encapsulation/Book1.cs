using System.Globalization;

namespace Encapsulation;

public class Book1
{

    public Book1(int id, string name, string author, double price)
    {
        Id = id;
        Name = name;
        Author = author;
        Price = price;
    }
    
    private double price;
    private string author;
    
    public int Id { get; set; }
    public string? Name { get; set; }
    
    //TODO: Yazar Adı Büyük Harfle Başlamalı
    public string? Author
    {
        get
        {
            return author;
        }
        set
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string capitalizeAuthor = textInfo.ToTitleCase(value);
            author = capitalizeAuthor;
        }
    }

    // TODO : Kitap fiyatına KDV uygula
    public double Price
    {
        get => price;
        set=>  price = value + value * 0.08; 
    }

    public override string ToString()
    {
        return $"Id : {Id}, Name : {Name}, Author: {Author}, Price : {Price}";
    }
}