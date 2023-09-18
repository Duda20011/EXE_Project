using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string CustomerName { get; set; }
        public string Avatar { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
