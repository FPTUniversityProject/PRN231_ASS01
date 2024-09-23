using Microsoft.EntityFrameworkCore;

namespace BusinessObject
{
    [Keyless]
    public class OrderDetail
    {
        public Int32 OrderId { get; set; }
        public Int32 ProductId { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public Decimal Discount { get; set; }
    }
}
