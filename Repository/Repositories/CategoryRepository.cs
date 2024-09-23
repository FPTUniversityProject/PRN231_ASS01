using BusinessObject;
using DataAccess;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetCategories()
            => CategoryDAO.GetCategories();
    }
}