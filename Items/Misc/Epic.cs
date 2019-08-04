using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using SomeShift.Buffs;
using Microsoft.Xna.Framework;

namespace SomeShift.Items.Misc
{
    class Epic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Signal Fire");
            Tooltip.SetDefault("Let enemies know, where are you");
            DisplayName.AddTranslation(GameCulture.Russian, "Сигнальная ракетница");
            Tooltip.AddTranslation(GameCulture.Russian, "Даёт противникам знать, где вы");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.MagicMirror);
            item.UseSound = SoundID.Item11; //Возможно, звук пойдёт сюда, а не туда
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType<EpicBuff>(),300*60);
            //Спавн парочки мобов-отсылок?
            //Всё говно, делаем через предмет
            //Звук сюда
            //Прожектайл сюда
            //Оффсеты сосут, поэтому тут будет что-нибудь связанное с положением рук
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            return (base.CanUseItem(player)) && (!player.HasBuff(mod.BuffType<EpicBuff>()));
        }
    }
}
