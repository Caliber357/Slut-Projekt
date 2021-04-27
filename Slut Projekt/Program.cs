using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dictionary<string, string> UserWeapons = new Dictionary<string, string>();
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
                }
            }


        }
    }
}
