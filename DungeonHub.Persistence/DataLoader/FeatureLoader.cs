using System.Text.Json;
using DungeonHub.Persistence.DataLoader.DataLoaderTypes;

namespace DungeonHub.Persistence.DataLoader;

public partial class DataLoader
{
    /// <summary>
    ///     Load the list of class features.
    /// </summary>
    /// <param name="featureFilePath">The path to the file containing the class features.</param>
    public void LoadFeatures(string featureFilePath = "../Data/class-feature.json")
    {
        var featuresJson = File.ReadAllText(featureFilePath);
        var featuresList = JsonSerializer.Deserialize<List<Feature>>(featuresJson)!;

        foreach (var feature in featuresList)
        {
            var classObject = dbContext.CharacterClasses.First(c => c.Name == feature.Class);

            var featureToAdd = new Models.Creature.Character.Feature
            { 
                Name = feature.Name,
                Description = feature.Description,
                Class = classObject,
                GainSubclassFeature = feature.GainSubclassFeature,
                IsSubclassFeature = feature.IsSubclassFeature
            };

            if (feature.IsSubclassFeature) 
            {
                var subclass = dbContext.CharacterSubclasses.First(c => c.Name == feature.Subclass);
                featureToAdd.Subclass = subclass;
            }
            
            dbContext.Features.Add(featureToAdd);
        }
        dbContext.SaveChanges();
    }
}