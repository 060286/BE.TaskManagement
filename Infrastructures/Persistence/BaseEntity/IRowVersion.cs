namespace BE.TaskManagement.Infrastructures.Persistence.BaseEntity
{
    public interface IRowVersion
    {
        long RowVersion { get; set; }
    }
}
