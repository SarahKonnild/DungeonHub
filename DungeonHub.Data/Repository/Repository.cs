using Microsoft.Extensions.Logging;

namespace DungeonHub.Backend.Repository;

/// <inheritdoc />
public partial class Repository(ILogger<Repository> logger, DungeonHubDbContext dungeonHubDbContext) : IRepository;