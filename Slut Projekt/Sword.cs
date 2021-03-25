using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class Sword: rngWeapon
    {

        public int rngSword() 
        {
            damage = rng.Next(1,11);
            durability = rng.Next(1,4);
            criticalStrike = rng.Next(1,3);
            weight = rng.Next(1,5);
            return
        }
    }
}
