using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            var result = new List<Product>();

            try
            {
                using var context = new Assignment01DbContext();
                result = [.. context.Products];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static Product FindProductById(int prodId)
        {
            var result = new Product();

            try
            {
                using var context = new Assignment01DbContext();
                result = context.Products.FirstOrDefault(prod => prod.ProductId == prodId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static void SaveProduct(Product product)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Products.Add(product);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateProduct(Product product)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Entry<Product>(product).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteProduct(int prodId)
        {
            try
            {
                using var context = new Assignment01DbContext();
                var productExisted = FindProductById(prodId);
                if (productExisted != null)
                {
                    context.Products.Remove(productExisted);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
