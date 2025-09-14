using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    internal class Formbehaelter
    {
        private Rechteck[] arrayRechteck = new Rechteck[2];
        private Dreieck[] arrayDreieck = new Dreieck[4];
        private Kreis[] arrayKreis = new Kreis[3];

        public Formbehaelter(int rechteckbreite1, int rechtecklaenge1, int rechteckbreite2, int rechtecklaenge2, int radius)
        {
            Console.WriteLine($"Ein Formbehälter wird erstellt.");
            arrayRechteck[0] = new Rechteck(rechteckbreite1, rechtecklaenge1);
            arrayRechteck[1] = new Rechteck(rechteckbreite2, rechtecklaenge2);
            arrayKreis[0] = new Kreis(radius);
            
        }

        public void RechteckCalcUmfang(int nummer)
        {
            Console.WriteLine($"Der Umfang des Rechtecks Nummer {nummer} wird berechnet.");
            arrayRechteck[nummer - 1].CalcUmfang();
        }
        public void RechteckCalcFlaeche(int nummer)
        {
            Console.WriteLine($"Die Fläche des Rechtecks Nummer {nummer} wird berechnet.");
            arrayRechteck[nummer - 1].CalcFlaeche();
        }

        public void DreieckCalcUmfang(int nummer)
        {
            Console.WriteLine($"Der Umfang des Dreiecks Nummer {nummer} wird berechnet.");
            arrayDreieck[nummer - 1].CalcUmfang();
        }
        public void DreieckCalcFlaeche(int nummer)
        {
            Console.WriteLine($"Die Fläche des Dreiecks Nummer {nummer} wird berechnet.");
            arrayDreieck[nummer-1].CalcFlaeche();
        }

        public void KreisCalcUmfang(int nummer)
        {
            Console.WriteLine($"Der Umfang des Kreises Nummer {nummer} wird berechnet.");
            arrayKreis[nummer-1].CalcUmfang();
        }
        public void KreisCalcFlaeche(int nummer)
        {
            Console.WriteLine($"Die Fläche des Kreises Nummer {nummer} wird berechnet.");
            arrayKreis[nummer-1].CalcFlaeche();
        }


        public void AddDreieck(int laenge)
        {
            if (arrayDreieck[0] == null)
            {
                arrayDreieck[0] = new Dreieck(laenge);
                return;
            }
            else if (arrayDreieck[1] == null)
            {
                arrayDreieck[1] = new Dreieck(laenge);
                return;
            }
            else if (arrayDreieck[2] == null)
            {
                arrayDreieck[2] = new Dreieck(laenge);
                return;
            }
            else if (arrayDreieck[3] == null)
            {
                arrayDreieck[3] = new Dreieck(laenge);
                return;
            }
            Console.WriteLine("Kein Platz mehr für weitere Dreiecke!");
        }

        /// <summary>
        /// Einen zusätzlichen Kreis hinzufügen. Es können aber insgesammt maximal 3 Kreise sein.
        /// </summary>
        /// <param name="radius">Kreisradius</param>
        public void AddKreis(int radius )
        {
            if (arrayKreis[1] == null)   
            {
                arrayKreis[1] = new Kreis(radius);
                return;
            }
            else if (arrayKreis[2] == null)
            {
                arrayKreis[2] = new Kreis(radius);
                return;
            }
            Console.WriteLine("Kein Platz mehr für weitere Kreise!");
        }
        
        
    }
}
