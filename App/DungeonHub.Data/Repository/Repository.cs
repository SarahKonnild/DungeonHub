using Microsoft.Extensions.Logging;

namespace DungeonHub.Data.Repository;

/// <inheritdoc />
public partial class Repository(ILogger<Repository> logger, DungeonHubDbContext dungeonHubDbContext) : IRepository;