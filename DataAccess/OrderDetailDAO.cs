using BusinessObject;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails()
        {
            var result = new List<OrderDetail>();

            try
            {
                using var context = new Assignment01DbContext();
                result = [.. context.OrderDetails];
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static OrderDetail FindOrderDetailById(int ordetailId)
        {
            var result = new OrderDetail();

            try
            {
                using var context = new Assignment01DbContext();
                result = context.OrderDetails.FirstOrDefault(order => order.OrderId == ordetailId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static void SaveOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.OrderDetails.Add(OrderDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateOrderDetail(OrderDetail OrderDetail)
        {
            try
            {
                using var context = new Assignment01DbContext();
                context.Entry<OrderDetail>(OrderDetail).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteOrderDetail(int ordetailId)
        {
            try
            {
                using var context = new Assignment01DbContext();
                var OrderDetailExisted = FindOrderDetailById(ordetailId);
                if (OrderDetailExisted != null)
                {
                    context.OrderDetails.Remove(OrderDetailExisted);
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
