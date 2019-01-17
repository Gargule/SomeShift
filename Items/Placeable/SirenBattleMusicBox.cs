using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ID;

namespace SomeShift.Items.Placeable
{
	public class SirenBattleMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Siren's War Cry)");
			Tooltip.SetDefault("From Calamity Mod");
			DisplayName.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка (Siren's War Cry)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("SirenBattleMusicBox");
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.value = 500000;
			item.accessory = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SirenLeviMusicBox");
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
