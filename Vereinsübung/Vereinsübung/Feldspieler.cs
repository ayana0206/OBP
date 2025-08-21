using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Feldspieler
    {
        public Feldspieler(string nameFeldspieler)
        {
            this.nameF = nameFeldspieler;
        }

        public string nameF { get; private set; }
    }
}
