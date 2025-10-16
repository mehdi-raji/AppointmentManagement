namespace AppointmentManagement.Domain.Appointment;

public class Appointment : AuditedEntity<int>
{
    public DateTime DateTime { get; set; }
}