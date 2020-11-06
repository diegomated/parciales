using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes.armas
{
    public class GranHacha : Weapon
    {
        public override int Daño()
        {
            return 19;
        }

        public override string RutaAcc()
        {
            return "/Images/gran-hacha.png";
        }

        public override string Nombre()
        {
            return "Gran Hacha";
        }
    }
}
