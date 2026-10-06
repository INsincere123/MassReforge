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
    }
}
