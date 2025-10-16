namespace AppointmentManagement.Domain.Plan;

public class Plan : AuditedEntity<short>
{
    public string Name { get; } = null!;

    public DateTime StartDate { get; }  
    public DateTime EndDate { get; } 

    protected Plan(short id)
    {
    }
}