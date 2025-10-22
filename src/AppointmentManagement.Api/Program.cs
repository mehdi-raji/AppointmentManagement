using AppointmentManagement.Api;
using AppointmentManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPresentation()
    .AddInfrastructure();

{
    var app = builder.Build();

    app.UseApiDocumentation(app);

    app.UseHttpsRedirection();

    app.MapControllers();
    app.Run();
}