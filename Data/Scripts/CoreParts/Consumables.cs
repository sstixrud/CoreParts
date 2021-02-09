using static Scripts.Structure;
using static Scripts.Structure.SupportDefinition;
using static Scripts.Structure.SupportDefinition.ModelAssignmentsDef;
using static Scripts.Structure.SupportDefinition.HardPointDef.HardwareDef.HardwareType;

namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ConsumeableDef Consumable1 => new ConsumeableDef
        {

                    ItemName = "item1",
                    InventoryItem = "SomeKeenName",
                    Hybrid = true,
                    EnergyCost = 123f,
                    Strength = 1000f,
                    ItemsNeeded = 2,

        };
        ConsumeableDef Consumable2 => new ConsumeableDef
        {

            ItemName = "item2",
            InventoryItem = "SomeKeenName2",
            Hybrid = true,
            EnergyCost = 123f,
            Strength = 1000f,
            ItemsNeeded = 1,
        };
    } // Don't edit below this line
}