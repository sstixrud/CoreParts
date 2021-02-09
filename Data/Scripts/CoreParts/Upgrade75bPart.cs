using static Scripts.Structure;
using static Scripts.Structure.UpgradeDefinition;
using static Scripts.Structure.UpgradeDefinition.ModelAssignmentsDef;
using static Scripts.Structure.UpgradeDefinition.HardPointDef;
using static Scripts.Structure.UpgradeDefinition.HardPointDef.HardwareDef.HardwareType;
namespace Scripts
{
    partial class Parts
    {
        // Don't edit above this line
        UpgradeDefinition Upgrade75b => new UpgradeDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "Upgrade75b",
                        DurabilityMod = 1f,
                        IconName = "",
                    },

                },
            },
            HardPoint = new HardPointDef
            {
                PartName = "Upgrade75b", // name of weapon in terminal

                Ui = new UiDef
                {
                },
                HardWare = new HardwareDef
                {
                    InventorySize = 1f,
                    Type = Default, //Default
                    BlockDistance = 6,
                },
                Other = new OtherDef
                {
                    ConstructPartCap = 0,
                    EnergyPriority = 0,
                    Debug = false,
                    RestrictionRadius = 0, // Meters, radius of sphere disable this gun if another is present
                    CheckInflatedBox = false, // if true, the bounding box of the gun is expanded by the RestrictionRadius
                    CheckForAnySupport = false, // if true, the check will fail if ANY gun is present, false only looks for this subtype
                },
            },
            Animations = Weapon75_Animation,
            Consumable = new[] {
                Consumable1,
                Consumable2
            },
            // Don't edit below this line
        };
    }
}