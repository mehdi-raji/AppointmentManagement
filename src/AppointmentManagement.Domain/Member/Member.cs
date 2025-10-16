namespace AppointmentManagement.Domain.Member;

public class Member : AuditedEntity<byte>
{
    public string Name { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string NationalCode { get; set; } = null!;
    
}