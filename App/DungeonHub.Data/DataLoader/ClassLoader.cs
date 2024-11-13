
namespace DungeonHub.Data.DataLoader;

public partial class DataLoader
{
    /// <summary>
    ///     Load the character classes.
    /// </summary>
    /// <param name="filePath">The path to the file containing the classes.</param>
    public void LoadCharacterClasses(string filePath = "../Data/classes.json")
    {
        var classesJson = File.ReadAllText(filePath);
        
    }
}