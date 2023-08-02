namespace BE.TaskManagement.Infrastructures.Persistence.BaseEntity
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedAt { get; set; }

        string DeletedBy { get; set; }
    }
}
