using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 CategoryId { get; set; }
        public String CategoryName { get; set; } = string.Empty;
    }
}
