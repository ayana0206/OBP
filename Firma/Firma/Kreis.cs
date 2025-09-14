using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Kreis
    {
        private int radius; 
        public Kreis(int radius) 
        {
            SetLinie(radius);
            this.radius = radius;
            Console.WriteLine($"Ein Kreis mit dem Radius {radius}cm wurde erstellt.");
            
        }

        public void SetLinie(int laengeradius)
        {
            Linie linie = new Linie(laengeradius);
        }

        public double CalcUmfang()
        {
            double umfang =Math.PI *(2* radius);
            Console.WriteLine($"Der Umfang des Kreises ist {umfang:F3} cm.");
            return umfang;
        }
        public double CalcFlaeche()
        {
            double flaeche = Math.PI * radius * radius;
            Console.WriteLine($"Die Fläche des Kreises ist {flaeche:F3} cm^2.");
            return flaeche;
        }
    }
}
