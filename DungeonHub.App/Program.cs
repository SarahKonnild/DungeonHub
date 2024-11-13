using DungeonHub.App.Setup;

WebApplication.CreateBuilder(args)
    .BuildDungeonHub()
    .Build()
    .UseDungeonHubApp()
    .Run();