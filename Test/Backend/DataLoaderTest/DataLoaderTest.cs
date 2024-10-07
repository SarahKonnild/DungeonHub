using System.IO.Abstractions;
using DungeonHub.Backend;
using DungeonHub.Persistence;
using DataLoader = DungeonHub.Backend.DataLoader.DataLoader;

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
    }
    
    public void Dispose()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Dispose();
    }
}