using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public class Member
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 MemberId { get; set; }
        public String Email { get; set; } = string.Empty;
        public String CompanyName { get; set; } = string.Empty;
        public String City { get; set; } = string.Empty;
        public String Country { get; set; } = string.Empty;
        public String Password { get; set; } = string.Empty;
    }
}
