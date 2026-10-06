using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MassReforge.Content.Items;

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
                shopCustomPrice = Item.buyPrice(platinum: 35),
            });
            shop.Add(new Item(ModContent.ItemType<WeaponReforgeScroll>())
            {
                shopCustomPrice = Item.buyPrice(platinum: 22),
            });
        }
    }
}
