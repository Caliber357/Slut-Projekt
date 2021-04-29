using System;

namespace Slut_Projekt
{
    public class Scythe: RngWeapon
    {
        public Scythe(){
            Name = "scythe";
            System.Console.WriteLine("I am scythe");
            stats.Add("ScytheDamage", rng.Next(1,11));
            stats.Add("ScytheDurability", rng.Next(1,11));
            stats.Add("ScytheCritChance", rng.Next(1,11));
            stats.Add("ScytheSharpness", rng.Next(1,11));
        }
    }
}
