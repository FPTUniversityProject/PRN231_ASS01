using BusinessObject;

namespace Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
