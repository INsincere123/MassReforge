using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MassReforge.Content.Items;
using MassReforge.Common.Configs;

namespace MassReforge.Common.GlobalNPCs
{
    public sealed class ReforgeScrollShop : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            if (shop.NpcType != NPCID.GoblinTinkerer)
                return;
            shop.Add(new Item(ModContent.ItemType<AccessoryReforgeScroll>())
            {
                shopCustomPrice = Item.buyPrice(platinum: 3),
            });
            shop.Add(new Item(ModContent.ItemType<WeaponReforgeScroll>())
            {
                shopCustomPrice = Item.buyPrice(platinum: 2),
            });
        }

        public override void ModifyActiveShop(NPC npc, string shopName, Item[] items)
        {
            if (npc.type != NPCID.GoblinTinkerer)
                return;
            var config = MassReforgeServerConfig.Instance;
            int weaponType = ModContent.ItemType<WeaponReforgeScroll>();
            int accessoryType = ModContent.ItemType<AccessoryReforgeScroll>();
            // 每次打开商店读取配置，让价格修改无需重新加载模组。
            foreach (Item item in items)
            {
                if (item == null || item.IsAir)
                    continue;
                if (item.type == weaponType)
                    item.shopCustomPrice = Item.buyPrice(platinum: Math.Clamp(config?.WeaponScrollPricePlatinum ?? 2, 1, 100));
                else if (item.type == accessoryType)
                    item.shopCustomPrice = Item.buyPrice(platinum: Math.Clamp(config?.AccessoryScrollPricePlatinum ?? 3, 1, 100));
            }
        }
    }
}
