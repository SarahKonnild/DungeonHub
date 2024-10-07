using DungeonHub.Backend;
using DungeonHub.Backend.Repository;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace Test.Backend.RepositoryTests;

public partial class RepositoryTest : IDisposable
{
    private readonly SqliteConnection _connection;
    private readonly DungeonHubDbContext _dungeonHubDbContext;
    private readonly ILogger<Repository> _loggerMock = Substitute.For<ILogger<Repository>>();
    private readonly Repository _repository;
    private bool _disposed;
    
    public RepositoryTest()
    {
        _connection = new SqliteConnection("DataSource=../../../Backend/RepositoryTests/TestDb/test.db");

        var options = new DbContextOptionsBuilder<DungeonHubDbContext>()
            .UseSqlite(_connection)
            .Options;
        
        _dungeonHubDbContext = new DungeonHubDbContext(options);
        _dungeonHubDbContext.Database.EnsureCreated();

        _repository = new Repository(_loggerMock, _dungeonHubDbContext);
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