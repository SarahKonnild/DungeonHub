using System.IO.Abstractions;
using DungeonHub.Persistence;
using DungeonHub.Persistence.DataLoader;

namespace Test.Backend.DataLoaderTest;

public partial class DataLoaderTest : IDisposable
{
    private readonly DungeonHubDbContext _dbContext;
    private readonly IFileSystem _fileSystem;
    private readonly DataLoader _dataLoader;

    public DataLoaderTest()
    {
        _dbContext = new DungeonHubDbContext();
        _dbContext.Database.EnsureCreated();
        _fileSystem = new FileSystem();
        _dataLoader = new DataLoader(_dbContext, _fileSystem);
    }
    
    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
        _dataLoader.Dispose();
    }
}