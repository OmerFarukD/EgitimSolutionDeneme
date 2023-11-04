// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
abstract class Employee
{
    public Employee(string department,string name, string location)
    {
        this.department = department;
        this.name = name;
        this.location = location;
    }
    

    public string department { get; set; }
    public string name { get; set; }
    public string location { get; set; }
    public bool isOnVacation { get; set; }

    public string GetDepartment()
    {
        return department;
    }

    public string GetName()
    {
        return name;
    }

    public bool GetStatus()
    {
        return isOnVacation;
    }

    public void SwitchStatus()
    {
        isOnVacation = !isOnVacation;
    }
}

class FinanceEmployee : Employee
{
    public FinanceEmployee( string name, string location) : base("Finance", name, location)
    {
    }
}

class MarketingEmployee: Employee
{
    public MarketingEmployee( string name, string location) : base("Marketing", name, location)
    {
    }
}

