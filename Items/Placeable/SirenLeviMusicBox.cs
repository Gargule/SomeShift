using Terraria.ModLoader;
using Terraria.Localization;

namespace SomeShift.Items.Placeable
{
	public class SirenLeviMusicBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Siren and Leviathan)");
			Tooltip.SetDefault("From Calamity Mod");
			DisplayName.AddTranslation(GameCulture.Russian, "Музыкальная шкатулка (Siren And Leviathan)");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = mod.TileType("SirenLeviMusicBox");
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.value = 500000;
			item.accessory = true;
		}
	}
}
