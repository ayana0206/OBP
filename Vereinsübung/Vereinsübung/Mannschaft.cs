using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Mannschaft
    {
        public Mannschaft(string nameMannschaft)
        {
            this.nameM = nameMannschaft;
        }
        private List<Feldspieler> feldspielerList = new List<Feldspieler>();
        public string nameM { get; private set; }
        public void addFeldspieler(List<string> namenFS)
        {
            foreach ( string name in namenFS)
            {
                feldspielerList.Add(new Feldspieler(namenFS));
            }
            
        }
    }
}
