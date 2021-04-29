using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class Sword: RngWeapon
    {
        public Sword(){
            // Använder en konstuktor för att köra koden här i när klassen instansieras
            Name = "sword";
            System.Console.WriteLine("I am sword");
            stats.Add("SwordDamage", rng.Next(1,11));
            stats.Add("SwordDurability", rng.Next(1,11));
            stats.Add("SwordCritChance", rng.Next(1,11));
            stats.Add("SwordSharpness", rng.Next(1,11));
            // Lägger stats med rätt ett index och value i Dictionaryt stats
        }

    }
}
