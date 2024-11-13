using DungeonHub.Data;
using Microsoft.AspNetCore.Identity;

namespace DungeonHub.App.Setup;

public static class ServiceExtensions
{
    public static WebApplicationBuilder BuildDungeonHub(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDungeonHubServices(connectionString);
        
        return builder;
    }

    private static IServiceCollection AddDungeonHubServices(this IServiceCollection services, string? dbConnectionString = null)
    {
        services
            .AddDungeonHubDataComponent(dbConnectionString)
            .AddDefaultIdentity<IdentityUser>()
            .AddEntityFrameworkStores<DungeonHubDbContext>();
        
        services.AddSignalR();
        
        return services;
    }
}