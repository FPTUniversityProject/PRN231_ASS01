using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using Repository.Repositories;

namespace Assignment01API.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository cateRepo = new CategoryRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
            => cateRepo.GetCategories();
    }
}
