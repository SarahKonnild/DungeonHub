using System.IO.Abstractions;

namespace DungeonHub.Data.DataLoader;

/// <summary>
///     Loads the data from the Data-folder into the database.
/// </summary>
public partial class DataLoader(DungeonHubDbContext dbContext, IFileSystem fileSystem) : IDisposable
{
    public void Dispose()
    {
        dbContext.Dispose();
        GC.SuppressFinalize(this);
    }
}