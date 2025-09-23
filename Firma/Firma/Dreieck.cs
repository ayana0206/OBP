using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Dreieck
    {
        private int seitenlaenge;

        private Linie[] arrayLinie = new Linie[3];


        public Dreieck(int laenge)
        {
            SetLinien(laenge);
            Console.WriteLine($"Ein gleichseitiges Dreieck mit der Seitenlänge {laenge}cm wurde erstellt.");
            seitenlaenge = laenge;
        }

        /// <summary>
        /// Es erstellt die drei Linien für das Dreieck.
        /// </summary>
        /// <param name="laenge">Seitenlaenge</param>
        public void SetLinien(int laenge)
        {
            for (int i = 0; i < 3; i++) 
            {
                arrayLinie[i] = new Linie(laenge);
            }
        }
        /// <summary>
        /// Berechnet den Umfang des gleichseitigen  Dreiecks.
        /// </summary>
        /// <returns>Umfang Dreieck</returns>
        public int CalcUmfang()
        {
            int umfang = seitenlaenge + seitenlaenge + seitenlaenge;
            Console.WriteLine($"Der Umfang des Dreiecks ist {umfang} cm.");
            return umfang;
        }
        /// <summary>
        /// Berechnet die Flaeche des gleichseitigen Dreiecks.
        /// </summary>
        /// <returns>Flaeche Dreieck</returns>
        public double CalcFlaeche()
        {
            double flaeche = (Math.Sqrt(3) / 4) * Math.Pow(seitenlaenge, 2);
            Console.WriteLine($"Die Fläche des Dreiecks ist {flaeche:F3} cm^2.");
            return flaeche;
        }
    }
}
