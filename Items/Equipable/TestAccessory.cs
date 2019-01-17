using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using SomeShift;
using System;
using System.Reflection;

namespace SomeShift.Items.Equipable
{
    public class TestAccessory : ModItem
    {
        static Mod Calamity = ModLoader.GetMod("CalamityMod");
        static ModItem LocalItem = Calamity.GetItem("SirenHeart");
        static ModItem LocalItem2;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TestAccessory");
            Tooltip.SetDefault("This is accessory for tests");
        }

        public override void SetDefaults()
        {
            item.
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Calamity != null)
            {
                LocalItem.UpdateAccessory(player, hideVisual);
                LocalItem2.UpdateAccessory(player, hideVisual);
            }
        }
    }
}
