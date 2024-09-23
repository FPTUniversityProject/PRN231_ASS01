using BusinessObject;

namespace Repository.Interfaces
{
    public interface IProductRepository
    {
        void SaveProduct(Product product);
        Product GetProductById(int proId);
        void DeleteProduct(int proId);
        void UpdateProduct(Product product);
        List<Product> GetProducts();
    }
}
