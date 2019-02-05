using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;

namespace SomeShift.Items.Equipable
{
    public class SirensLeviHeartGreen : SirensLeviHeart
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Siren's heart (Green)");
            Tooltip.SetDefault("Have all abilities from Siren's heart and Leviathan Ambergris");

            DisplayName.AddTranslation(GameCulture.Russian, "Истинное сердце Сирены (Зелёное)");
            Tooltip.AddTranslation(GameCulture.Russian, "Имеет все возможности Сердца Сирены и Амбры Левиафана");
        }
    }
}
