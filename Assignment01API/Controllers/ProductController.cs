using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using Repository.Repositories;

namespace Assignment01API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductRepository prodRepo = new ProductRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
            => prodRepo.GetProducts();

        [HttpPost]
        public IActionResult CreateProducts(Product product)
        {
            prodRepo.SaveProduct(product);
            return NoContent();
        }

        [HttpPut("id")]
        public IActionResult UpdateProducts(int id, Product product)
        {
            var prodExist = prodRepo.GetProductById(id);
            if (prodExist == null)
            {
                return NotFound();
            }
            prodRepo.UpdateProduct(product);
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult DeleteProducts(int id)
        {
            var prodExist = prodRepo.GetProductById(id);
            if (prodExist == null)
            {
                return NotFound();
            }
            prodRepo.DeleteProduct(id);
            return NoContent();
        }
    }
}
