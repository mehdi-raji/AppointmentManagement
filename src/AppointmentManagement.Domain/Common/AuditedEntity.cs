namespace AppointmentManagement.Domain.Common;

public abstract class AuditedEntity<TKey> : Entity<TKey> where TKey : IComparable<TKey>
{
    private DateTime CreatedOn { get; set; }
    private int CreatedUserId { get; set; }
    private DateTime UpdatedOn { get; set; }
    private int UpdatedUserId { get; set; }


    public void SetCreationInfo(int userId, DateTime createdOn)
    {
        CreatedUserId = UpdatedUserId = userId;
        CreatedOn = UpdatedOn = createdOn;
    }

    public void SetModificationInfo(int userId, DateTime updatedOn)
    {
        UpdatedUserId = userId;
        UpdatedOn = updatedOn;
    }
}