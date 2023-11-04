using System.Collections;

Console.WriteLine("Hello, World!");
//Arrays 

int[] sayiArray= new int[3];

sayiArray[0]=1;
sayiArray[1]=10;
sayiArray[2]=100;
//[1,10,100]

//TODO: Bu array hakkında bilgi alalım.
Console.WriteLine($"Bu arrayda kaç eleman var : {sayiArray.Length}");
Console.WriteLine($"Bu arrayin boyutu ne : {sayiArray.Rank}");
Console.WriteLine($"Bu arrayin tipi ne : {sayiArray.GetType()}");
Console.WriteLine(sayiArray);

// TODO: Array içerisinde yazan sayıları ekrana bas
// TODO: for döngüsü ile 
for (int i = 0; i < sayiArray.Length; i++)
{
    Console.WriteLine($"dizinin {i+1}. elemanı : {sayiArray.GetValue(i)}");
}

//TODO: foreach döngüsü ile tüm sayıları yazdırma 1.Yöntem
foreach(int sayi in sayiArray) {
    Console.WriteLine(sayi);
}

int[] sayiArray2 = new int[5] {1,2,3,5,6};

// ArrayList

ArrayList arrayList= new ArrayList()
{
    1,2,3,"Ömer"
};
arrayList.Add(1);
arrayList.Add(10);
arrayList.Add(100);
arrayList.Add(120);
arrayList.Add("Selam");
arrayList.Remove(10);

Console.WriteLine($"ArrayListin Boyutu : {arrayList.Count}");
Console.WriteLine($"ArrayListin Tipi : {arrayList.GetType()}");

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

//TODO: Tip güvenli ve dinamik koleksiyonlar :List

List<string> isimler = new List<string>()
{
    "Vahdet","Sayit","Rümeysa","Eda"
};
isimler.Add("Furkan");

Console.WriteLine("isimler");
foreach (var isim in isimler)
{
    Console.WriteLine(isim);
}
// TODO: .ForEach() metodu ile ekrana yazı yazdıralım;
Console.WriteLine("2. Yöntem");
isimler.ForEach(isim=>Console.WriteLine(isim));

// TODO: Dictionary veri yapısı
// TODO: Plakaların şehir karşılığını tutan bir Sözlük yapısı kurun  34 : "İstanbul"
Dictionary<int,string> cities= new Dictionary<int, string>()
{
    {02,"Adıyaman"},{34,"İstanbul"},{06,"Ankara"}
};

cities.Add(44,"Malatya");
cities.Add(45,"Malatya");

Console.WriteLine(cities[02]);
foreach (var item in cities)
{
    Console.WriteLine($"{item.Key} plakalı şehrimizin Adı : {item.Value}");
}

// TODO : While Döngüleri 
List<int> sayilar = new List<int>() { 1,2,3,6,5,8,7,10};

int j = 0;
 while (j < sayilar.Count)
{
    Console.WriteLine($"{j+1}. Eleman : {sayilar[j]}");
    j++;
}
// TODO: do While

int k = 0;

do
{
    Console.WriteLine(k);
    k++;
} while (k<5);
