namespace BE.TaskManagement.Infrastructures.Persistence.BaseEntity
{
    public interface IKey<TType>
    {
        TType Id { get; set; }
    }
}
