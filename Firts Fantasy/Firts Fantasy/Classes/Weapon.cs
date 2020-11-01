using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes
{
    class Weapon
    {
        private int damage;
        private int durability;

        public int Damage { get => damage; set => damage = value; }
        public int Durability { get => durability; set => durability = value; }
    }
}
