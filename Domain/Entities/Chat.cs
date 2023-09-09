

using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Chat : BaseEntity
    {
        public string Content { get; set; }
        public DateTime Date { get; set; }

    }
}
