using System;

namespace Slut_Projekt
{
    public class WeaponSpawner
    {
        RngWeapon whatever = new RngWeapon();
        Random rng = new Random();

        public RngWeapon Spawner()
        {
            switch (rng.Next(4))
            {
                case 0:
                    whatever = new Sword();
                    break;
                case 1:
                    whatever = new Bow();
                    break;
                case 2:
                    whatever = new Axe();
                    break;
                case 3:
                    whatever = new Scythe();
                    break;
                default:
                    System.Console.WriteLine("ooops");
                    break;
            }

            return whatever;
        }





    }
}
