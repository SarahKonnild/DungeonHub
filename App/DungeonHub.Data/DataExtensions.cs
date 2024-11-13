using DungeonHub.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DungeonHub.Data;

public static class DataExtensions
{
    public static IServiceCollection AddDungeonHubDataComponent(this IServiceCollection services, string? dbConnectionString = null)
    {
        services.AddDbContext<DungeonHubDbContext>(options => options.UseSqlite(dbConnectionString));

        services.AddSingleton<IRepository, Repository.Repository>();
        
        return services;
    }
}