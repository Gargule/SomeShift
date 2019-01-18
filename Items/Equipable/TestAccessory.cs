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

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TestAccessory");
            Tooltip.SetDefault("This is accessory for tests");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(Calamity.ItemType("LeviathanAmbergris"));
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Calamity != null)
            {
                ModItem LocalItem1 = Calamity.GetItem("SirensHeart");
                ModItem LocalItem2 = Calamity.GetItem("LeviathanAmbergris");
                LocalItem1.UpdateAccessory(player, hideVisual);
                LocalItem2.UpdateAccessory(player, hideVisual);
            }
        }
    }
}
