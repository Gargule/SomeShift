using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.ID;

namespace SomeShift.Items.Misc
{
    public class WaterSprayer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Water Sprayer");
            Tooltip.SetDefault("When in inventory you have a chance to inflict 'Wet' with attacks");
            DisplayName.AddTranslation(GameCulture.Russian, "Распылитель");
            Tooltip.AddTranslation(GameCulture.Russian, "Пока находится в инвентаре вы имеете шанс намочить противника атакой");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 0;
            item.rare = 6;
        }

        public override void UpdateInventory(Player player)
        {
            player.AddBuff(mod.BuffType("Sprayer"), 60); //Технически, любой аксесуар может работать из инвентаря, если немного поковырять его код, как видно отсюда
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBucket);
            recipe.AddIngredient(ItemID.MetalSink); //Сделано жопой, переделать через крафтовый группы
            recipe.AddIngredient(ItemID.OutletPump);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
