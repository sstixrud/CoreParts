using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition Armor1 => new ArmorDefinition
        {
            SubtypeId = "Durasteel",
            EnergeticResistance = 0.95f,
            KineticResistance = 0.82f,
            Kind = Heavy,
        };
        ArmorDefinition Armor2 => new ArmorDefinition
        {
            SubtypeId = "Beskar",
            EnergeticResistance = 1f,
            KineticResistance = 0.96f,
            Kind = Light,
        };
    }
}