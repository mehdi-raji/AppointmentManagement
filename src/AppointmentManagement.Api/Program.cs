using AppointmentManagement.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddPresentation();

{
    var app = builder.Build();

    app.UseApiDocumentation(app);

    app.UseHttpsRedirection();

    app.MapControllers();
    app.Run();
}