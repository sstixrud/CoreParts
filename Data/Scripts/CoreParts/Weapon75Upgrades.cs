using System.Collections.Generic;
using static Scripts.Structure.PartDefinition;

namespace Scripts
{
    partial class Parts
    {
        private Dictionary<string, UpgradeValues[]> UpgradeModules => new Dictionary<string, UpgradeValues[]>
        {
            ["blockName1"] = new[] {
                new UpgradeValues {
                    Ammo = new[] {
                        "AmmoType1",
                        "AmmoType2",
                    },
                    AmmoPriority = 0,
                    RateOfFireMod = 100,
                    BarrelsPerShotMod = 1,
                    DelayAfterBurstMod = -10,
                    HeatSinkRateMod = 10,
                    MaxHeatMod = 100,
                    ReloadMod = -5,
                    ShotsInBurstMod = 15,
                },
                new UpgradeValues
                {
                    Ammo = new[] {
                        "AmmoType3",
                        "AmmoType4",
                    },
                    AmmoPriority = 1,
                    RateOfFireMod = 200,
                    BarrelsPerShotMod = 2,
                    DelayAfterBurstMod = -20,
                    HeatSinkRateMod = 20,
                    MaxHeatMod = 200,
                    ReloadMod = -10,
                    ShotsInBurstMod = 30,
                },
            },
            ["blockName2"] = new[] {
                new UpgradeValues {
                    Ammo = new[] {
                        "AmmoType5",
                    },
                    AmmoPriority = 2,
                    RateOfFireMod = 100,
                    BarrelsPerShotMod = 1,
                    DelayAfterBurstMod = -10,
                    HeatSinkRateMod = 10,
                    MaxHeatMod = 100,
                    ReloadMod = -5,
                    ShotsInBurstMod = 15,
                },
            },
        };
    }
}