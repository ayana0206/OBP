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
    }
}
