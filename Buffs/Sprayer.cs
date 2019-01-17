using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace SomeShift.Buffs
{
    public class Sprayer : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Water sprayer");
            Description.SetDefault("Have a chance to inflict 'Wet'");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = false;
            Main.buffNoTimeDisplay[Type] = true;
            DisplayName.AddTranslation(GameCulture.Russian, "Распылитель воды");
            Description.AddTranslation(GameCulture.Russian, "Вы имеете шанс намочить врага");
        }
    }
}
