using Microsoft.Extensions.DependencyInjection;
using System.Data;
using CleanArchitecture.Application.Repositories;
using Microsoft.Extensions.Configuration;
using CleanArchitecture.Persistence.Repositories;
using System.Data.SqlClient;
using CleanArchitecture.Persistence.Authenticate;

namespace CleanArchitecture.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        // Configurar IDbConnection
        services.AddTransient<IDbConnection>(db => new SqlConnection(connectionString));

        // Repositorios
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped(typeof(IAuthRepository), typeof(AuthRepository));

    }
}