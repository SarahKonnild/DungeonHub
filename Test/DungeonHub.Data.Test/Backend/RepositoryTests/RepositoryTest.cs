using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace DungeonHub.Data.Test.Backend.RepositoryTests;

public partial class RepositoryTest : IDisposable
{
    private readonly SqliteConnection _connection;
    private readonly DungeonHubDbContext _dungeonHubDbContext;
    private readonly ILogger<Repository.Repository> _loggerMock = Substitute.For<ILogger<Repository.Repository>>();
    private readonly Repository.Repository _repository;
    private bool _disposed;
    
    public RepositoryTest()
    {
        _connection = new SqliteConnection("DataSource=../../../Backend/RepositoryTests/TestDb/test.db");

        var options = new DbContextOptionsBuilder<DungeonHubDbContext>()
            .UseSqlite(_connection)
            .Options;
        
        _dungeonHubDbContext = new DungeonHubDbContext(options);
        _dungeonHubDbContext.Database.EnsureCreated();

        _repository = new Repository.Repository(_loggerMock, _dungeonHubDbContext);
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        _connection.Close();
        _dungeonHubDbContext.Database.EnsureDeleted();
        _dungeonHubDbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}