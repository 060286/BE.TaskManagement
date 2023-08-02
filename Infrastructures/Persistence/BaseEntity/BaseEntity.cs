namespace BE.TaskManagement.Infrastructures.Persistence.BaseEntity
{
    public abstract class BaseEntity : IEditable, IDeletable
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string? DeletedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public string? ModifiedBy { get; set; }
    }
}
