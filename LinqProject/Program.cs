using LinqProject.Data;
using LinqProject.Models;

var productsData= new ProductData();
var categoriesData= new CategoryData();

var products = productsData.GetAllProducts();
var categories = categoriesData.GetAllCategories();

// LINQ kullanmadan =>
// todo: Senaryo 1 : Ürünleri listeleyen kodu yazınız

Console.WriteLine("Ürünleri listeleyen kodu yazınız");
foreach (var product in products)
{
    
    Console.WriteLine(product.ToString());
}


//todo: Senaryo 2: Ürünlerden CategoryId si 1 olanları yazdırın
Console.WriteLine("Ürünlerden CategoryId si 1 olanları yazdırın");
foreach (var product in products)
{
    if (product.CategoryId.Equals(1) )
    {
        Console.WriteLine(product.ToString());
    }
}

//todo: Senaryo 3 : Ürünler listesinde ProductName' i "ung" içeren ürünleri getiriniz
Console.WriteLine("Ürünler listesinde ProductName' ung içeren ürünleri getiriniz");

foreach (var product in products)
{
    if (product.ProductName.Contains("ung"))
    {
        Console.WriteLine(product.ToString());
    }
}

// todo: Senaryo 4 : bütün ürünlerin fiyatlarının toplamını bul.
Console.WriteLine("bütün ürünlerin fiyatlarının toplamını bul.");

decimal total = 0;
foreach (var product in products)
{
    total+=product.UnitPrice;
}
Console.WriteLine(total);

Console.WriteLine("------------LINQ------------");

// LINQ kullanarak yapalım
Console.WriteLine("1.SENARYO --LINQ-- ");
products.ForEach(x=>Console.WriteLine(x.ToString()));

Console.WriteLine("2.SENARYO --LINQ-- ");
products.Where(x=>x.CategoryId.Equals(1)).ToList().ForEach(x=>Console.WriteLine(x.ToString()));

Console.WriteLine("3.SENARYO --LINQ-- ");
products.Where(x => x.ProductName.Contains("ung")).ToList().ForEach(x=>Console.WriteLine(x.ToString()));

Console.WriteLine("4.SENARYO --LINQ-- ");
 Console.WriteLine($"Ürünlerin Toplamı : {products.Sum(x => x.UnitPrice)}");


//TODO: Ürün Değerlerinin Ortalamasını alan kodu Yazınız.
Console.WriteLine($"Ürünlerin Aritmetik Ortalaması : {products.Average(x=>x.UnitPrice)}");

// TODO: CategoryId si 1 Olan ürünlerin Fiyatlarının Toplamı;
var data = products.Where(x => x.CategoryId.Equals(1)).ToList();
Console.WriteLine($"CategoryId si 1 Olan ürünlerin Fiyatlarının Toplamı : {data.Sum(x=>x.UnitPrice)}");

// TODO: CategoryId si 4 olan ürün varmı kontrolü;
bool dogruluk = products.Any(x=>x.CategoryId==4);
Console.WriteLine($"Ürün var mı : {dogruluk}");

// TODO: CategoryId si 3 olan tek ürünü yazdır;
Console.WriteLine(products.SingleOrDefault(x=>x.CategoryId==3)?.ToString());

// TODO: Tüm ürünlerin sadece ProductName lerini yazdıran kod;

var productNameList = products.Select(x => x.ProductName).ToList();
productNameList.ForEach(x=>Console.WriteLine($"Ürün Adı : {x}"));


//TODO: CategoryId lerine göre Ürünleri gruplandıran ve listeleyen kod;
var groupedProducts = products.GroupBy(x => x.CategoryId)
    .ToDictionary(g=>g.Key , g=>g.ToList());

foreach (var group in groupedProducts)
{
    Console.WriteLine($"{group.Key} CategoryId sine sahip ürünler");
    /*foreach (var product in group.Value)
    {
        Console.WriteLine(product.ToString());
    }*/
    group.Value.ForEach(x=>Console.WriteLine(x.ToString()));
}


//TODO: Tüm Ürünleri Fiyatları artan özellik gösterecek şekilde sıralayalım.
//1. yol
products.Sort(new Product());

Console.WriteLine("Sıralanmış veri");
products.ForEach(x=>Console.WriteLine(x.ToString()));
products.Reverse();
Console.WriteLine("Ters Sıralanmış veri : ");
products.ForEach(x=>Console.WriteLine(x.ToString()));
// 2. Yol 
Console.WriteLine("Sıralanmış veri 2. Yol");
var ascendingUnitPriceList = products.OrderBy(x=>x.UnitPrice).ToList();
ascendingUnitPriceList.ForEach(x=>Console.WriteLine(x.ToString()));
Console.WriteLine("Ters Sıralanmış veri 2.Yol");
var descendingUnitPriceList = products.OrderByDescending(x => x.UnitPrice).ToList();
descendingUnitPriceList.ForEach(x=>Console.WriteLine(x.ToString()));

//todo: ***Kullanıcıya  {ProductName, CategoryName, UnitPrice, UnitsInStock} bilgilerini gösteriniz***;
var details = from p in products
    join c in categories on p.CategoryId equals c.Id
    select new ProductDetailDto()
    {
        CategoryName = c.Name,
        ProductName = p.ProductName,
        UnitPrice = p.UnitPrice,
        UnitsInStock = p.UnitsInStock
    };

var result = details.ToList();
Console.WriteLine("Kullanıcı Detayları : ");
result.ForEach(x=>Console.WriteLine(x.ToString()));

// TODO: Joinli datanın CategoryId si 2 olan tüm verileri yazdıran kod:
var joinResult= from pr in products join c in categories on pr.CategoryId equals c.Id
                               where  c.Id.Equals(2) select new ProductDetailDto()
                               {
                                   CategoryName = c.Name,
                                   ProductName = pr.ProductName,
                                   UnitPrice = pr.UnitPrice,
                                   UnitsInStock = pr.UnitsInStock
                               };
var listOfResult = joinResult.ToList();
Console.WriteLine("Joinli datanın CategoryId si 2 olan tüm verileri yazdıran kod:");
listOfResult.ForEach(x=>Console.WriteLine(x.ToString())); 


// TODO: ***Kullanıcıya  {ProductName, CategoryName, UnitPrice, UnitsInStock} bilgilerini gösteriniz*** 2. Yöntem;

var lambdaJoin= products.Join(categories,
    p=>p.CategoryId,
    c=>c.Id,
    (p,c)=> new ProductDetailDto()
    {
       CategoryName = c.Name,
       ProductName = p.ProductName,
       UnitPrice = p.UnitPrice,
       UnitsInStock = p.UnitsInStock
    }
    ).ToList();
Console.WriteLine("ProductDetailsDto 2. Yöntemi");
lambdaJoin.ForEach(x=>Console.WriteLine(x.ToString()));

//TODO: Joinli datanın CategoryId si 2 olan tüm verileri yazdıran kod 2. Yöntem:

var joinFilterData = products.Where(x=>x.CategoryId.Equals(2)).Join(categories,
    p => p.CategoryId,
    c => c.Id,
    (pr, ca) => new ProductDetailDto()
    {
        CategoryName = ca.Name,
        ProductName = pr.ProductName,
        UnitPrice = pr.UnitPrice,
        UnitsInStock = pr.UnitsInStock
    }
).ToList();
Console.WriteLine("Joinli datanın CategoryId si 2 olan tüm verileri yazdıran kod 2. Yöntem:");
joinFilterData.ForEach(x=>Console.WriteLine(x.ToString()));

// 2 Sayı Listeleri arasında olabilecek aksiyonlar
List<int> numbers1 = new List<int>() { 1, 2, 3, 4, 5 };
List<int> numbers2 = new List<int>() { 4, 5, 6, 7, 8 };
List<int> numbers3 = new List<int>() {1,1,2,2,10,3,4,5 };


// TODO: 2 Sayı Listesinde ortak olan sayıları Tek liste halide listelemek
Console.WriteLine("2 Sayı Listesinde ortak olan sayıları Tek liste halide listelemek");
var intersectNumbers = numbers1.Intersect(numbers2).ToList();
intersectNumbers.ForEach(x=>Console.WriteLine(x));

//TODO: 1. Sayı Listesinde bulunan ama 2. Sayı Listesinde Bulunmayan Sayıların Listeesi;
Console.WriteLine("1. Sayı Listesinde bulunan ama 2. Sayı Listesinde Bulunmayan Sayıların Listeesi;");
var exceptNumbers = numbers1.Except(numbers2).ToList();
exceptNumbers.ForEach(x=>Console.WriteLine(x));

//TODO: 1. Sayı Listesinde Bulunan sayıların Çarpımı
Console.WriteLine($"1. Listedeki elemanların çarpımı : {numbers1.Aggregate((a,b)=>a*b)}");

//TODO: 3. Sayı Listesinde Bulunan Benzersiz Sayılar
var distinctNumbers=numbers3.Distinct().ToList();
Console.WriteLine("Benzersiz Sayılar");
distinctNumbers.ForEach(x=>Console.WriteLine(x));

// TODO: 3 Listesini tek 1 Liste haline Getirme

var concatedList= numbers1.Concat(numbers2).Concat(numbers3).ToList();
Console.WriteLine("Tek liste: ");
concatedList.ForEach(x=>Console.Write(x));
Console.WriteLine();

// TODO: 1. Listede Bulunan en küçük ve en büyük sayı ;

var min= numbers1.Min();
var max= numbers1.Max();
Console.WriteLine($"1. Listede en küçük eleman : {min} En büyük eleman : {max}");

// TODO: 2. Listede 2 den büyük 3 tane sayı alan yeni liste

var newList=numbers2.Where(x=>x>2).Take(3).ToList();
Console.WriteLine("Listede 2 den büyük 3 tane sayı alan yeni liste");
newList.ForEach(x=>Console.Write(x));
Console.WriteLine();
// TODO: 1.ve 2. Listenin Unique Birleşimi

var uniqueNumbers = numbers1.Union(numbers2).ToList();
Console.WriteLine("Unique Birleşim");
uniqueNumbers.ForEach(x=>Console.Write(x));

// TODO: 1. ve 2. Listedeki elemanların indexlerine göre toplama örneğin 1.Listenin 1. indexi+ 2.Listenin 1. indexi +... ve index toplamlarını bir listede tutma

var zippedList = numbers1.Zip(numbers2, (a, b) => a + b).ToList(); 
Console.WriteLine("İndex toplamı listesi");
zippedList.ForEach(x=>Console.Write(x));
Console.WriteLine();
