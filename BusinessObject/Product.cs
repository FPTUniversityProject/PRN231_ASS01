using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 ProductId { get; set; }
        public Int32 CategoryId { get; set; }
        public String ProductName { get; set; } = string.Empty;
        public Decimal Weight { get; set; }
        public Decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        
    }
}
