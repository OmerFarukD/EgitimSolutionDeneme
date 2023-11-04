// See https://aka.ms/new-console-template for more information

using Classes;

Person p = new Person();
Person p1= new ()
{
    Name = "Ahmet",
    Age = 20,
    Surname = "Bulut"
};
var p2= new Person(24,"Mehmet","Furkan");
var p3 = new Person(name:"Sayit", age:22,surname:"Bulut");

p.Name="Ömer";
p.Surname = "Doğan";
p.Age=25;


Console.WriteLine($"Ad : {p.Name}, Soyad : {p.Surname}, Yaş : {p.Age}");
Console.WriteLine($"Ad : {p1.Name}, Soyad : {p1.Surname}, Yaş : {p1.Age}");
Console.WriteLine($"Ad : {p2.Name}, Soyad : {p2.Surname}, Yaş : {p2.Age}");
Console.WriteLine($"Ad : {p3.Name}, Soyad : {p3.Surname}, Yaş : {p3.Age}");
string deneme=new string("bu bir yazıdır");
