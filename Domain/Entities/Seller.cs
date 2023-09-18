using Domain.Entities.Base;
namespace Domain.Entities
{
    public class Seller : BaseEntity
    {
        public string SellerName { get; set; }
        public string Avatar { get; set; }
        public string Phone { get; set; }

    }
}
