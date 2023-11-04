namespace Classes;

// Özellik tutan class
public class Person
{
    public Person()
    {
        
    }
    
    public Person(int age, string name, string surname)
    {
        Age = age;
        Name = name;
        Surname = surname;
    }
    
    public string Name;
    public string Surname;
    public int Age;
}