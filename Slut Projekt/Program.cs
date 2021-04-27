using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, rngWeapon> UserWeapons = new Dictionary<string, rngWeapon>();
            Dictionary<string, Dictionary<string, int>> reeeee = new Dictionary<string, Dictionary<string, int>>();
            bool end = false;
            while (!end)
            {
                string choice = Console.ReadLine();

                if (choice == "end")
                {
                    end = true;
                }
                else
                {
                    WeaponSpawner spawner = new WeaponSpawner();
                    rngWeapon weapon = spawner.Spawner();
                    UserWeapons.Add(weapon.Name, weapon);
                }
            }


        }
    }
}
