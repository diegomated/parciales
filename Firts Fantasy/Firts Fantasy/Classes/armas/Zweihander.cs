using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes.armas
{
    public class Zweihander : Weapon
    {
        public override int Daño()
        {
            return 25;
        }

        public override string RutaAcc()
        {
            return "/Images/zweihander.png";
        }

        public override string Nombre()
        {
            return "Zweihander";
        }
    }
}
