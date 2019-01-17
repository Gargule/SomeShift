using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace SomeShift
{
    public class SomeShiftNPCPlayer : ModPlayer
    {
        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (player.HasBuff(mod.BuffType("Sprayer")))
            {
                target.buffImmune[BuffID.Wet] = false;
                target.AddBuff(BuffID.Wet, 600);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (player.HasBuff(mod.BuffType("Sprayer")))
            {
                target.buffImmune[BuffID.Wet] = false;
                target.AddBuff(BuffID.Wet, 600);
            }
        }
    }
}
