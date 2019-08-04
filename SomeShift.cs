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
    }
}
