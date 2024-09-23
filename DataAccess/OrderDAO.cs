using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {
            var result = new List<Order>();

            try
            {
                using var context = new Assignment01DbContext();
                result = [.. context.Orders];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static Order FindOrderById(int orderId)
        {
            var result = new Order();

            try
            {
                using var context = new Assignment01DbContext();
                result = context.Orders.FirstOrDefault(order => order.OrderId == orderId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static void SaveOrder(Order Order)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Orders.Add(Order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateOrder(Order Order)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Entry<Order>(Order).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteOrder(int orderId)
        {
            try
            {
                using var context = new Assignment01DbContext();
                var OrderExisted = FindOrderById(orderId);
                if (OrderExisted != null)
                {
                    context.Orders.Remove(OrderExisted);
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
