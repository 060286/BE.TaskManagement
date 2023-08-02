namespace BE.TaskManagement.Infrastructures.Persistence.BaseEntity
{
    public interface IEditable
    {
        DateTime? CreatedAt { get; set; }

        string CreatedBy { get; set; }

        DateTime? ModifiedAt { get; set; }

        string ModifiedBy { get; set; }
    }
}
