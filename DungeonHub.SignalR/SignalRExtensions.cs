namespace DungeonHub.SignalR;

public static class SignalRExtensions
{
    /// <summary>
    ///     Use the SignalR Hubs for the DungeonHub.
    /// </summary>
    /// <param name="app">The web application to use the SignalR hubs on.</param>
    /// <returns>The web application for chaining.</returns>
    public static WebApplication UseDungeonHubSignalR(this WebApplication app)
    {
        app.MapHub<CharacterHub>("/character");
        app.MapHub<MonsterHub>("/monster");
        
        return app;
    }
}