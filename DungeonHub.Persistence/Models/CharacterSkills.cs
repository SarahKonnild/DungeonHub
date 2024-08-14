using System.ComponentModel.DataAnnotations.Schema;

namespace DungeonHub.Persistence.Models;

/// <summary>
///     Represents a character's skills.
/// </summary>
public class CharacterSkills
{
    /// <summary>
    ///     The ID of the set of character skills.
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public required int AcrobaticsModifier { get; set; }

    public required bool AcrobaticsProficient { get; set; }
    
    public required int AnimalHandlingModifier { get; set; }
    
    public required bool AnimalHandlingProficient { get; set; }
    
    public required int ArcanaModifier { get; set; }
    
    public required bool ArcanaProficient { get; set; }
    
    public required int AthleticsModifier { get; set; }
    
    public required bool AthleticsProficient { get; set; }
    
    public required int DeceptionModifier { get; set; }
    
    public required bool DeceptionProficient { get; set; }
    
    public required int HistoryModifier { get; set; }
    
    public required bool HistoryProficient { get; set; }
    
    public required int InsightModifier { get; set; }
    
    public required bool InsightProficient { get; set; }
    
    public required int IntimidationModifier { get; set; }
    
    public required bool IntimidationProficient { get; set; }
    
    public required int InvestigationModifier { get; set; }
    
    public required bool InvestigationProficient { get; set; }
    
    public required int MedicineModifier { get; set; }
    
    public required bool MedicineProficient { get; set; }
    
    public required int NatureModifier { get; set; }
    
    public required bool NatureProficient { get; set; }
    
    public required int PerceptionModifier { get; set; }
    
    public required bool PerceptionProficient { get; set; }
    
    public required int PerformanceModifier { get; set; }
    
    public required bool PerformanceProficient { get; set; }
    
    public required int PersuasionModifier { get; set; }
    
    public required bool PersuasionProficient { get; set; }
    
    public required int ReligionModifier { get; set; }
    
    public required bool ReligionProficient { get; set; }
    
    public required int SleightOfHandModifier { get; set; }
    
    public required bool SleightOfHandProficient { get; set; }
    
    public required int StealthModifier { get; set; }
    
    public required bool StealthProficient { get; set; }
    
    public required int SurvivalModifier { get; set; }
    
    public required bool SurvivalProficient { get; set; }
}