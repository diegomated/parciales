using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes
{
    public abstract class Weapon
    {
        private int durability;

        public int Durability { get => durability; set => durability = value; }

        public abstract int Daño();

        public abstract string RutaAcc();

        public abstract string Nombre();

    }
}
