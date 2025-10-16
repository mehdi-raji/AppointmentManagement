namespace AppointmentManagement.Domain.User;

public class User : AuditedEntity<int>
{

    public string UserName { get; set; } = null!;
    public string FirstName { get; } = null!;
    public string LastName { get; } = null!;
    public string PhoneNumber { get; set; } = null!;
    
    private readonly string _passwordHash = null!;
}