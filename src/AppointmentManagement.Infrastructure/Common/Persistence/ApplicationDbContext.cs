using System.Reflection;
using AppointmentManagement.Domain.Appointment;
using AppointmentManagement.Domain.Member;
using AppointmentManagement.Domain.Office;
using AppointmentManagement.Domain.Plan;
using AppointmentManagement.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace AppointmentManagement.Infrastructure.Common.Persistence;

public class ApplicationDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Plan> Plans { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }
    
}