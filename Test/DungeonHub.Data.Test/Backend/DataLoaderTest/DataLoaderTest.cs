using System.IO.Abstractions;

namespace DungeonHub.Data.Test.Backend.DataLoaderTest;

public partial class DataLoaderTest : IDisposable
{
    private readonly DungeonHubDbContext _dbContext;
    private readonly IFileSystem _fileSystem;
    private readonly DataLoader.DataLoader _dataLoader;

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