using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoApi.Application.Interfaces;

//using ProyectoApi.Application.Interfaces;
using ProyectoApi.Infrastructure.Persistence;
using ProyectoApi.Infrastructure.Services;
using Prueba.Application.Queries.Users;
//using ProyectoApi.Infrastructure.Repositories;

namespace ProyectoApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        AddDatabase(services, configuration);
        AddRepositories(services);
        AddHandlers(services);
        AddExternalServices(services);

        return services;
    }

    private static void AddDatabase(
    IServiceCollection services,
    IConfiguration configuration)
    {
        var connectionString =
            configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(
                connectionString,
                ServerVersion.AutoDetect(connectionString)));
    }

    private static void AddRepositories(
        IServiceCollection services)
    {
        //services.AddScoped<IUserRepository, UserRepository>();
    }


    private static void AddHandlers(
        IServiceCollection services)
    {
        services.AddScoped<GetConnectionHandler>();
    }

    private static void AddExternalServices(
        IServiceCollection services)
    {
        services.AddScoped<UserService, UserService>();
        services.AddScoped<IConnectionRepository, BDService>();
    }
}