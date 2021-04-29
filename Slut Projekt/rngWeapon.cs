using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class RngWeapon
    {
        protected Random rng = new Random();
        // En Random som jag gjorde för att bara subklasserna av "RngWeapon" behöver kunna använda Random i programmet
        public Dictionary<string, int> stats = new Dictionary<string, int>();
        // Detta är Dictionary som parar ihop stats med deras values 
        // Dictionaryet blir en del av 2D Dictionaryt i Program.cs
        public string Name { get; protected set; }
        //

    }
}
