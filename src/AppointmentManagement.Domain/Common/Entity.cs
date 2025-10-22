namespace AppointmentManagement.Domain.Common;

public abstract class Entity<TId> where TId : IComparable<TId>
{
    public virtual TId Id { get; protected set; }

    protected Entity()
    {
    }

    protected Entity(TId id) => this.Id = id;
}