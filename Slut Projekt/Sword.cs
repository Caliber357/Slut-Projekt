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
            stats.Add("Sword Damage", rng.Next(1,11));
            stats.Add("Sword Durability", rng.Next(1,11));
            stats.Add("Sword Crit Chance", rng.Next(1,11));
            stats.Add("Sword Sharpness", rng.Next(1,11));
            // Lägger stats med rätt ett index och value i Dictionaryt stats
        }

    }
}
