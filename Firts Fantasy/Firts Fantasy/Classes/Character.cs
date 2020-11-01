using System;
using System.Collections.Generic;
using System.Text;

namespace Firts_Fantasy.Classes
{
    public abstract class Character
    {
        private string name;
        private int level;
        private int expereince;

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int Expereince { get => expereince; set => expereince = value; }
    }
}
