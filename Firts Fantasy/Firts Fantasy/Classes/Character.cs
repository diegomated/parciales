using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes
{
    public abstract class Character
    {
        private string name;
        private List<string> inventory;
        private Weapon arma;
        private List<string> armadura;
        static public int vida = 200;

        public string Name { get => name; set => name = value; }
        public List<string> Inventory { get => inventory; set => inventory = value; }
        public Weapon Arma { get => arma; set => arma = value; }
        public List<string> Armadura { get => armadura; set => armadura = value; }

        public abstract string tipoClase();
    }
}
