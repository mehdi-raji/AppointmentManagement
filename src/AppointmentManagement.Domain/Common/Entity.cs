namespace AppointmentManagement.Domain.Common;

public abstract class Entity<TKeyType>
{
    public TKeyType Id { get; init; }
}