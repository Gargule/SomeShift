using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using SomeShift.Projectiles;

namespace SomeShift.Items.Weapons.Poles
{
    class WoodenPole : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wooden pole");
            Tooltip.SetDefault("Strike or swing?");
            DisplayName.AddTranslation(GameCulture.Russian, "Деревянный шест");
            Tooltip.AddTranslation(GameCulture.Russian, "Раскрутить или ударить?");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodenSword);
            item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
            item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useTime = 30;
                item.useAnimation = 30;
                item.damage = 5;
                item.shootSpeed = 24f;
                item.knockBack = 5f;
                item.width = 16;
                item.height = 16;
                item.autoReuse = true;
                item.channel = true;
                item.shoot = mod.ProjectileType<PoleSwing>();

            }
            else
            {
                item.useTime = 300;
                item.useAnimation = 30;
                item.damage = 6;
                item.shootSpeed = 2.7f;
                item.knockBack = 2.5f;
                item.width = 16;
                item.height = 16;
                item.scale = 1f;
                item.autoReuse = false;
                item.channel = false;
                item.shoot = mod.ProjectileType<PoleStrike>();
            }
            return (base.CanUseItem(player)) && (player.ownedProjectileCounts[item.shoot] < 1);
        }
    }
}
