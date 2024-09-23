using BusinessObject;
using DataAccess;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class OderDelailRepository : IOrderDetailRepositoty
    {
        public void DeleteOrderDetail(int orderDetailId)
           => OrderDetailDAO.DeleteOrderDetail(orderDetailId);

        public OrderDetail GetOrderDetailById(int orderDetailId)
            => OrderDetailDAO.FindOrderDetailById(orderDetailId);

        public List<OrderDetail> GetOrderDetails()
            => OrderDetailDAO.GetOrderDetails();

        public void SaveOrderDetail(OrderDetail orderDetail)
            => OrderDetailDAO.SaveOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail)
            => OrderDetailDAO.UpdateOrderDetail(orderDetail);
    }
}
