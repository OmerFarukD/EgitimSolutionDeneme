using ClassAndRecords;

Car car1 = new Car()
{
  Name  = "Opel Astra",
  Price = 2000000
};
Car car2 = new Car()
{
  Name  = "Opel Astra",
  Price = 2000000
};

if (car1 == car2)
{
  Console.WriteLine("2 class birbirine eşittir");
}
else
{
  Console.WriteLine("2 class birbirine eşit değildir.");
}

// Bus bus = new Bus()
// {
//   Name = "Otobüs",
//   Price = 20000000000
// };
// Bus bus1 = new Bus()
// {
//   Name = "Otobüs",
//   Price = 20000000000
// };
//
// if (bus == bus1)
// {
//   Console.WriteLine("2 Record birbirine eşittir.");
// }
// else
// {
//   Console.WriteLine("2 record birbirine eşit değildir.");
// }
Car car3=new Car("BMW",2000000);
Console.WriteLine(car3.Name);

Car car4 = new Car()
{
  Name = "Renault",
  Price = 2000000
};
Console.WriteLine(car4.Name);

Bus bus = new Bus()
{
  Name = "Otobos",
  Price = 20000000
};