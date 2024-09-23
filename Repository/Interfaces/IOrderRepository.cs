using BusinessObject;

namespace Repository.Interfaces
{
    public interface IOrderRepository
    {
        void SaveOrder(Order order);
        Order GetOrderById(int orderId);
        void DeleteOrder(int orderId);
        void UpdateOrder(Order order);
        List<Order> GetOrders();
    }
}
