using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class rngWeapon
    {
        
        protected int damage = 0;
        protected int durability = 0;
        protected int criticalStrike = 0;
        protected int weight = 0;
        protected Random rng = new Random();
        public static int weapon;

        private int typeOfWeapon = 0;
        public int NewWeapon(){
            typeOfWeapon = rng.Next(1,5);
            weapon = typeOfWeapon;
            return weapon;
        }
        
    }
}
