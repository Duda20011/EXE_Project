

namespace Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? ModificationBy { get; set; }
        public DateTime? DeletionDate { get; set; }
        public int? DeleteBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
