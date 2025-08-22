using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Praesident
    {
        public Praesident(string name)
        {
            this.name = name;
        }

        public string name { get; private set; }
    }
}
