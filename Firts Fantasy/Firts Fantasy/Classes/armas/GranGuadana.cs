using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes.armas
{
    public class GranGuadana : Weapon
    {
        public override int Daño()
        {
            return 15;
        }

        public override string RutaAcc()
        {
            return "/Images/gran-guadana.png";
        }

        public override string Nombre()
        {
            return "Gran Guadaña";
        }

    }
}
