using System;
using System.Collections.Generic;
namespace Slut_Projekt
{
    public class RngWeapon
    {
        protected Random rng = new Random();
        public Dictionary<string, int> stats = new Dictionary<string, int>();
        public string Name { get; protected set; }


    }
}
