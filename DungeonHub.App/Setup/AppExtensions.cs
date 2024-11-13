using DungeonHub.SignalR;

namespace DungeonHub.App.Setup;

public static class AppExtensions
{
    public static WebApplication UseDungeonHubApp(this WebApplication app)
    {
        app
            .UseDungeonHubSignalR()
            .UseHttpsRedirection()
            .UseRouting()
            .UseAuthorization();
        
        return app;
    }
}