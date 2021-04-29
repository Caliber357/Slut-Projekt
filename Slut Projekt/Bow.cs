using System;

namespace Slut_Projekt
{
    public class Bow: RngWeapon
    {
        public Bow(){
            Name = "bow";
            System.Console.WriteLine("I am bow");
            stats.Add("BowDamage", rng.Next(1,11));
            stats.Add("BowDurability", rng.Next(1,11));
            stats.Add("BowCritChance", rng.Next(1,11));
            stats.Add("Range", rng.Next(1,11));
        }
    }
}
