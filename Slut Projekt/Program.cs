using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    class Program
    {


        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> UserWeapons = new Dictionary<string, Dictionary<string, int>>();
            // Dictionary med en string som index och ett annat Dictionary som valuen som använder en string som index 
            // och en int som value
            WeaponSpawner spawner = new WeaponSpawner();
            // Denna linjen instansierar classen "WeaponSpawner"
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
                    RngWeapon weapon = spawner.Spawner();
                    // Skapar ett nytt "RngWeapon" med spawnern som jag gjorde tidigare
                    if (!UserWeapons.ContainsKey(weapon.Name))
                    {
                        UserWeapons.Add(weapon.Name, weapon.stats);
                    }
                    // Om det inte finns en "weapon" med samma index i Dictionaryt "UserWeapons" så läggs "weapon" till
                    else
                    {
                        UserWeapons[weapon.Name] = weapon.stats;

                        System.Console.WriteLine($"already contains a {weapon.Name}");
                    }
                    // Om det finns en weapon med samma index
                }
            }


        }


    }
}
