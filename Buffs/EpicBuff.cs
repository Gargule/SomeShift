using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;


namespace SomeShift.Buffs
{
    class EpicBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Epic Aggro");
            Description.SetDefault("Now you are EPIC");
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            canBeCleared = true;
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.AddTranslation(GameCulture.Russian, "Эпичный агр");
            Description.AddTranslation(GameCulture.Russian, "Теперь вы ЭПИЧНЫ");
        }
        //Тут бафф, возможно, будет как-нибудь действовать. Или мы будем хардкодить через модплеера
    }
}
