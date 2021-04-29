using System;

namespace Slut_Projekt
{
    public class Axe: RngWeapon
    {
        public Axe(){
            Name = "axe";
            System.Console.WriteLine("I am axe");
            stats.Add("AxeDamage", rng.Next(1,11));
            stats.Add("AxeDurability", rng.Next(1,11));
            stats.Add("AxeCritChance", rng.Next(1,11));
            stats.Add("AxeSharpness", rng.Next(1,11));
        }
    }
}
