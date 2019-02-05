using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;

namespace SomeShift.Items.Equipable
{
    public class SirensLeviHeart : ModItem
    {
        protected static Mod Calamity = ModLoader.GetMod("CalamityMod");
        protected static ModItem LocalItem1 = Calamity.GetItem("SirensHeart");
        protected static ModItem LocalItem2 = Calamity.GetItem("LeviathanAmbergris");

        public override void SetStaticDefaults()
        {
            // Он пуст, т.к. данный метод всегда переопределяется в потомках.
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(Calamity.ItemType("LeviathanAmbergris"));
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Calamity != null)
            {
                LocalItem1.UpdateAccessory(player, hideVisual);
                LocalItem2.UpdateAccessory(player, hideVisual);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(LocalItem1, 1);
            recipe.AddIngredient(LocalItem2, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
