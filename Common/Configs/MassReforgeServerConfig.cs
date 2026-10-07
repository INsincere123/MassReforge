using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MassReforge.Common.Configs
{
    [BackgroundColor(30, 30, 50)]
    public sealed class MassReforgeServerConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        public static MassReforgeServerConfig Instance { get; private set; }
        public override void OnLoaded() => Instance = this;
        internal static void ClearInstance() => Instance = null;

        [Header("Reforging")]
        [DefaultValue(true)]
        public bool IgnoreCalamityHorriblePrefix { get; set; } = true;

        [DefaultValue(true)]
        public bool PreferRuthlessForSummonWeapons { get; set; } = true;

        [DefaultValue(10)]
        [Range(1, 100)]
        public int WeaponScrollPricePlatinum { get; set; } = 10;

        [DefaultValue(15)]
        [Range(1, 100)]
        public int AccessoryScrollPricePlatinum { get; set; } = 15;
    }
}
