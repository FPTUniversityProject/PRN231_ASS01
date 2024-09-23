using BusinessObject;
using DataAccess;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int orderId)
           => OrderDAO.DeleteOrder(orderId);

        public Order GetOrderById(int orderId)
            => OrderDAO.FindOrderById(orderId);

        public List<Order> GetOrders()
            => OrderDAO.GetOrders();

        public void SaveOrder(Order order)
            => OrderDAO.SaveOrder(order);

        public void UpdateOrder(Order order)
            => OrderDAO.UpdateOrder(order);
    }
}
