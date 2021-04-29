using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class Sword: RngWeapon
    {

        public Sword(){
            Name = "sword";
            System.Console.WriteLine("I am sword");
            stats.Add("Damage", rng.Next(1,11));
        }

    }
}
