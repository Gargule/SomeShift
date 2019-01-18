using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;

namespace SomeShift.Items.Equipable
{
    public class SirensLeviHeart : ModItem
    {
        static Mod Calamity = ModLoader.GetMod("CalamityMod");
        static ModItem LocalItem1 = Calamity.GetItem("SirensHeart");
        static ModItem LocalItem2 = Calamity.GetItem("LeviathanAmbergris");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wet Siren's heart (Blue)");
            Tooltip.SetDefault("Have all abilities from Siren's heart and Leviathan Ambergris");

            DisplayName.AddTranslation(GameCulture.Russian, "Истинное сердце Сирены (Синее)");
            Tooltip.AddTranslation(GameCulture.Russian, "Имеет все возможности Сердца Сирены и Амбры Левиафана");
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
