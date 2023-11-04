Console.WriteLine("Hello, World!");


// TODO: ilk önce değişken tanımlayalım;
int sayi1=10;
int sayi2=10;

var sayi = 30;

sayi = sayi1;

string kelime = "Ömer";
bool dogruluk=true ;
double ondalik = 10.4;
// TODO : String Interpolation
Console.WriteLine(dogruluk);
Console.WriteLine($"İki Sayının Toplamı = {sayi1+sayi2}");
Console.WriteLine($"kelime değişkeninin değeri = {kelime}");

// TODO : if, else if, else

var deger = 10;

if (deger < 10)
{
    Console.WriteLine($" {deger} 10 dan küçüktür.");
}else if (deger is  10)
{
    Console.WriteLine($"{deger} sayısı 10 sayısına eşittir.");
}
else
{
    Console.WriteLine($"{deger} sayisi 10 dan büyüktür.");
}

//TODO: switch case 
//TODO: Senaryo 2 kullanıcıdan 2 sayı aldığımızı var sayalım bu sayılarla toplama çıkarma toplama gibi işlemler yapalım.

string operators = "+";
int number1 = 1;
int number2 = 2;
int sonuc= operators switch
{
    "+"=> number1+number2,
    "-"=> number1-number2,
    "*"=> number1*number2,
    "/"=> number1/number2,
    _=> 0
};
Console.WriteLine($"İşlemin sonucu : {sonuc}");

// TODO: for ve foreach , while döngüleri;

List<int> sayilar = new List<int>()
{
    1,2,3,4,5,6,7,8,9,10
};
// TODO: for ile bütün verileri ekrana yazdıralım. Break
for (var i=0; i<sayilar.Count;i++)
{
    Console.WriteLine($"sayı : {sayilar[i]}");
}

// TODO: While 
int j = 0;
while (j < sayilar.Count)
{
    Console.WriteLine(sayilar[j]);
    j++;
}
EkranaYazdir();
Console.WriteLine(EkranaAdYazdır("Ömer","Doğan"));

// TODO: Metodlar 

 void EkranaYazdir()
{
    Console.WriteLine("Ekrana Yazdir.");
}

string EkranaAdYazdır(string name, string surname)
{
    return $"isim : {name}, soyisim : {surname}";
}