using System;

namespace Slut_Projekt
{
    public class WeaponSpawner
    {
        RngWeapon weapon = new RngWeapon();
        // Instansierar klassen "RngWeapon"
        Random rng = new Random();

        public RngWeapon Spawner()
        // Switchen använder Randomen "rng" för att kunna assigna en subklass av "RngWeapon" till den ny gjorda weapon
        {
            switch (rng.Next(4))
            {
                case 0:
                    weapon = new Sword();
                    break;
                case 1:
                    weapon = new Bow();
                    break;
                case 2:
                    weapon = new Axe();
                    break;
                case 3:
                    weapon = new Scythe();
                    break;
                default:
                    System.Console.WriteLine("ooops");
                    break;
            }

            return weapon;
        }
    }
}
