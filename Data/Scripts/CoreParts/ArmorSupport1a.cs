using static Scripts.Structure;
using static Scripts.Structure.SupportDefinition;
using static Scripts.Structure.SupportDefinition.ModelAssignmentsDef;
using static Scripts.Structure.SupportDefinition.HardPointDef.HardwareDef.HardwareType;

namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        SupportDefinition ArmorEnhancer1a => new SupportDefinition
        {

            Assignments = new ModelAssignmentsDef
            {
                MountPoints = new[] {
                    new MountPointDef {
                        SubtypeId = "ArmorSupport1a",
                        DurabilityMod = 1f,
                        IconName = "",
                    },
                    
                },
            },
            HardPoint = new HardPointDef
            {
                PartName = "ArmorSupport1a", // name of weapon in terminal

                Ui = new HardPointDef.UiDef
                {
                },
                HardWare = new HardPointDef.HardwareDef
                {
                    InventorySize = 1f,
                    Type = Default, //Default
                },
                Other = new HardPointDef.OtherDef
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
            // Don't edit below this line
        };
    }
}