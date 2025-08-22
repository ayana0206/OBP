using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vereinsübung
{
    internal class Mannschaft
    {
        public Mannschaft(string Motto, List<string> namenFS, List<string> namenT)
        {
            this.Motto = Motto;
            this.addFeldspieler(namenFS);
            this.addTorwart(namenT);
        } 
        
       public string Motto { get; private set; }


        // Feldspieler
        private List<Feldspieler> feldspielerList = new List<Feldspieler>();       
        public void addFeldspieler(List<string> namenFS)
        {

            foreach ( string name in namenFS)
            {
                feldspielerList.Add(new Feldspieler(name));

            }
            
        }

        // Torwart
        private List<Torwart> torwartList = new List<Torwart>();
        public void addTorwart(List<string> namenT)
        {
            foreach (string name in namenT)
            {
                torwartList.Add(new Torwart(name));
            }
        }


        public void TorSchiessen() 
        { 

        }
    }
}
