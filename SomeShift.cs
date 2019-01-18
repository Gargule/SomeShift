using Terraria;
using Terraria.ModLoader;

namespace SomeShift
{
    public class SomeShift : Mod
    {
       public SomeShift()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public override void Load()
        {
            Mod Calamity = ModLoader.GetMod("CalamityModMusic");
            if (!Main.dedServ) //Как я понял, это определяет, являемся ли мы выделенным сервером, чтобы снизить нагрузку в случае если являемся
            {
                if (Calamity != null)
                {
                    AddMusicBox(Calamity.GetSoundSlot(SoundType.Music, "Sounds/Music/SirenLure"), ItemType("SirenMusicBox"), TileType("SirenMusicBox"));
                    AddMusicBox(Calamity.GetSoundSlot(SoundType.Music, "Sounds/Music/Siren"), ItemType("SirenBattleMusicBox"), TileType("SirenBattleMusicBox"));
                    AddMusicBox(Calamity.GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndSiren"), ItemType("SirenLeviMusicBox"), TileType("SirenLeviMusicBox"));
                }
            }
        }
    }
}
