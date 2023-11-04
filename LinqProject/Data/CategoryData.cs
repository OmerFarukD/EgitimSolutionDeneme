using LinqProject.Models;

namespace LinqProject.Data;

public class CategoryData
{
    private List<Category> _categories;

    public CategoryData()
    {
        _categories = new List<Category>()
        {
            new Category() { Id = 1, Name = "Telefon"},
            new Category() { Id = 2, Name = "Bilgisayar"},
            new Category() { Id = 3, Name = "Kulaklık"},
        };
    }
    
    public List<Category> GetAllCategories()
    {
        return _categories;
    }
}