using ExampleProject.Tables;

namespace ExampleProject.Operations.GenericOperations;

public interface IGenericOperation<TTable> where TTable: BaseTable, new()
{
    void Add(TTable author);
    List<TTable> GetAll();
    TTable GetById(int id);
}