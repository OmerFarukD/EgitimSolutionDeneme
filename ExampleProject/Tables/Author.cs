namespace ExampleProject.Tables;

public class Author : BaseTable
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $" Id : {Id}, Adı : {Name}";
    }
    
}