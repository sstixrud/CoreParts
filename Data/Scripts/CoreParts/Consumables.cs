using static Scripts.Structure;

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