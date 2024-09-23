using BusinessObject;
using DataAccess;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void DeleteProduct(int prodId)
            => ProductDAO.DeleteProduct(prodId);

        public Product GetProductById(int prodId)
            => ProductDAO.FindProductById(prodId);

        public List<Product> GetProducts()
            => ProductDAO.GetProducts();

        public void SaveProduct(Product product)
            => ProductDAO.SaveProduct(product);

        public void UpdateProduct(Product product)
            => ProductDAO.UpdateProduct(product);
    }
}
