using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Torwart
    {
        public Torwart(string nameTorwart)
        {
            this.nameT = nameTorwart;
        }

        public string nameT { get; private set; }

        public void BallHalten()
        {
            Console.WriteLine($"Der Torwart {nameT} hat den Ball werfolgreich gehalten :)");
        }
    }
}
