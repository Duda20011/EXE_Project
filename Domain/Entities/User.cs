using Domain.Entities.Base;
using Domain.Entities.Enum;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public Guid CustormerId { get; set; }
        public Customer Customer { get; set; }
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
