
namespace AppointmentManagement.Domain.Office;

public class Office : AuditedEntity<byte>
{
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    

    protected Office()
    {
    }
}