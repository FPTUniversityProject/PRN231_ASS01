using BusinessObject;

namespace Repository.Interfaces
{
    public interface IOrderDetailRepositoty
    {
        void SaveOrderDetail(OrderDetail OrderDetail);
        OrderDetail GetOrderDetailById(int orderId);
        void DeleteOrderDetail(int orderId);
        void UpdateOrderDetail(OrderDetail OrderDetail);
        List<OrderDetail> GetOrderDetails();
    }
}
