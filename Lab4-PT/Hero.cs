using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PT
{
    class Hero
    {
        public string Name { get; private set; }
        public string Profession { get; private set; }
        public int Strength { get; private set; }
        public int Intelligence { get; private set; }

        public Hero(string name, string profession, int strength, int intelligence)
        {
            this.Name = name;
            this.Profession = profession;
            this.Strength = strength;
            this.Intelligence = intelligence;
        }
    }
}
