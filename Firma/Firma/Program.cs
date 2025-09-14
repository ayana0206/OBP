namespace Firma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo und Wilkommen bei der Fima 'GeoShapes'.");
            Console.WriteLine("");
            // Es werden 2 Rechtecke und ein Kreis instanziert wenn ein Formbehälter erstellt wird.
            Formbehaelter formbehaelter1 = new Formbehaelter(20, 30, 44, 33, 10);
            Console.WriteLine("");

            // Masse berechnen Rechteck 1
            formbehaelter1.RechteckCalcUmfang(1);
            formbehaelter1.RechteckCalcFlaeche(1);
            Console.WriteLine("");

            //Masse berechnen Rechteck 2 
            formbehaelter1.RechteckCalcUmfang(2);
            formbehaelter1.RechteckCalcFlaeche(2);
            Console.WriteLine("");

            // Dreieck1 erstellen und Masse berechnet
            formbehaelter1.AddDreieck(22);
            formbehaelter1.DreieckCalcUmfang(1);
            formbehaelter1.DreieckCalcFlaeche(1);
            Console.WriteLine("");

            // Masse berechnen Kreis1
            formbehaelter1.KreisCalcUmfang(1);
            formbehaelter1.KreisCalcFlaeche(1);
            Console.WriteLine("");

            // Kreis2 erstellen und Masse berechnen
            formbehaelter1.AddKreis(8);
            formbehaelter1.KreisCalcUmfang(2);
            formbehaelter1.KreisCalcFlaeche(2);
            Console.WriteLine("");

            Console.WriteLine(Math.PI);
        }
    }
}
