namespace AppointmentManagement.Api;

public static class Pipeline
{
    public static IApplicationBuilder UseApiDocumentation(this IApplicationBuilder builder, WebApplication app)
    {
        if (!app.Environment.IsDevelopment()) return builder;
        
        app.MapOpenApi();
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            options.RoutePrefix = string.Empty;
        });

        return builder;
    }
}