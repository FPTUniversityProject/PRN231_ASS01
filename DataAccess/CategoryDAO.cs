using BusinessObject;

namespace DataAccess
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            var result = new List<Category>();

            try
            {
                using var context = new Assignment01DbContext();
                result = [.. context.Categories];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
