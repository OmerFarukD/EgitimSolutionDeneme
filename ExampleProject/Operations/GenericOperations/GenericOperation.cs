using ExampleProject.Tables;

namespace ExampleProject.Operations.GenericOperations;

public class GenericOperation<TEntity>  : IGenericOperation<TEntity>
where TEntity: BaseTable, new()
{
    private List<TEntity> _list;

    public GenericOperation()
    {
        _list = new List<TEntity>();
    }

    public void Add(TEntity entity)
    {
        _list.Add(entity);
        _list.ForEach(x=>Console.WriteLine(x.ToString()));
    }

    public List<TEntity> GetAll()
    {
        return _list;
    }
    
    public TEntity GetById(int id)
    {
        TEntity table = new TEntity();
        
        foreach (var entity in _list)
        {
            if (entity.Id == id)
            {
                table = entity;
            }
        }

        return table;
    }
}