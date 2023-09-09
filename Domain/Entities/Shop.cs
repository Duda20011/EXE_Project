

using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Shop : BaseEntity
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
    }
}
