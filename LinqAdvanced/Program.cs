
using LinqAdvanced.Data;
using LinqAdvanced.Models;

var products = Repository.Products;
var categories = Repository.Categories;
//Todo: Tüm ürünler arasından id si 1 olan verileri listeleyen kodu yazınız.

//1.Yöntem
/*foreach (var product in products)
{
    if (product.Id is 1)
    {
        Console.WriteLine(product);
    }
}*/

//2. Yöntem 
// var productList = from product in products where product.Id ==1 select product;
// foreach (var item in productList)
// {
//     Console.WriteLine(item);
// }
// 3.Yöntem
// products.Where(x=>x.Id==1).ToList().ForEach(x=> Console.WriteLine(x));

//TODO: Ürün isimlerinden içinde ung geçen ürünleri listeleyen kodu yazınız

//1.Yöntem
/*foreach (var product in products)
{
    if (product.Name.Contains("ung"))
    {
        Console.WriteLine(product);
    }
}*/

// 2. Yöntem
/*var productsList = from product in products where  product.Name.Contains("ung") select product;
foreach (var product in productsList)
{
    Console.WriteLine(product); 
}*/

//3. Yöntem
/*products.Where(x=>x.Name.Contains("ung")).ToList().ForEach(c=> Console.WriteLine(c));*/

//TODO: Ürünlerin Fiyatlarının  toplamını bulunuz
//1. Yöntem
/*double total = 0;
foreach (var product in products)
{
    total += product.Price;
}
Console.WriteLine($"Ürünlerin fiyatının toplamı : {total}");*/

//2. Yöntem 
/*var total = products.Sum(x=>x.Price);
Console.WriteLine($"Ürünlerin toplamı: {total}");*/

//TODO: CategoryId si 2 Olan ürünlerin toplamını ekrana bastıran kodu yazınız.
/*var total_2 = products.Where(x => x.CategoryId == 2).Sum(p=>p.Price); 
var total_1 = products.Where(x => x.CategoryId == 1).Sum(p=>p.Price); 
var total_3 = products.Where(x => x.CategoryId == 3).Sum(p=>p.Price); 
Console.WriteLine($"category Id si 2 olan ürünlerin fiyatlarının toplamı : {total_2}");
Console.WriteLine($"category Id si 1 olan ürünlerin fiyatlarının toplamı : {total_1}");
Console.WriteLine($"category Id si 3 olan ürünlerin fiyatlarının toplamı : {total_3}");*/

//TODO: Ürünlerin fiyatlarının ortalamasını alan kodu yazınız.
var ortalama = products.Average(x=>x.Price);
Console.WriteLine($"Tüm ürünlerin fiyatlarının ortalaması : {ortalama} ");
