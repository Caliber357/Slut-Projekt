using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    class Program
    {
        static List<rngWeapon> UserWeapons = new List<rngWeapon>();
        static void Main(string[] args)
        {    
            WeaponSpawner spawner = new WeaponSpawner();
            rngWeapon weapon = spawner.Spawner();
        }
    }
}
