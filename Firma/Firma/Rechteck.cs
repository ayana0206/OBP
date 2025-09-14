using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    public class Rechteck
    {
        private int laengeBreite;
        private int laengeLaenge;

        private Linie[] arrayBreite = new Linie[2];
        private Linie[] arrayLaenge = new Linie[2];



        public Rechteck(int breite, int laenge)
        {
            SetLinie(breite, laenge);
            laengeBreite = breite;
            laengeLaenge = laenge;
            Console.WriteLine($"Ein Rechteck mit der Breite {breite}cm und der Länge {laenge}cm wurde erstellt.");
        }

        public void SetLinie(int breite, int laenge)
        {
            for (int i = 0; i < 2; i++)
            {
                arrayBreite[i] = new Linie(breite);
            }
            for (int i = 0; i < 2; i++)
            {
                arrayLaenge[i] = new Linie(laenge);
            }
        }

        public int CalcUmfang()
        {
            int umfang = (2 * laengeBreite) + (2 * laengeLaenge);
            Console.WriteLine($"Der Umfang des Rechtecks ist {umfang} cm.");
            return umfang;
        }
        public int CalcFlaeche()
        {
            int flaeche = laengeBreite * laengeLaenge;
            Console.WriteLine($"Die Fläche des Rechtecks ist {flaeche} cm^2.");
            return flaeche;
        }
    }
}
