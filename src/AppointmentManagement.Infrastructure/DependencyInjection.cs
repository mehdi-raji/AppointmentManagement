using AppointmentManagement.Infrastructure.Common.Persistence;
using  AppointmentManagement.Infrastructure.Common.Accessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentManagement.Infrastructure;

public static class DependencyInjection
{
 
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services
            .AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(Environment
                    .GetEnvironmentVariable(DatabaseAccessor.DataBaseVariable)));
    }
}