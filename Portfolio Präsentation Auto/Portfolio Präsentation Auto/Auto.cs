using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio_Präsentation_Auto
{
    internal class Auto
    {
        // Fields
        private string marke;
        private int sitzplaetze;

        // Properties
        public int BenzinStand { get; set; }

        // Constructor
        public Auto(string marke, int sitzplaetze ) 
        {
            this.marke = marke;
            this.sitzplaetze = sitzplaetze;
        }

        // Methoden
        public void Fahren(int geschwindigkeit)
        {
            if (BenzinStand > 0) 
            {
                BenzinStand = BenzinStand - 1;
                Console.WriteLine($"Ich fahre mit {geschwindigkeit} km/h.");
            }
            else
            {
                Console.WriteLine("Das Benzin reicht nicht");
            }
        }
        public void KofferraumOeffnen() 
        {
            Console.WriteLine("Der Kofferraum ist offen.");
        }
    }
}
