using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Physiotherapeut
    {
        public Physiotherapeut(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void Massieren(string name)
        {
            Console.WriteLine($"Ich {Name} massiere {name}.");
        }
    }
}
