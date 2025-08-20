namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int zahl = MyMath.Calc_ggT(12, 16);
            Console.WriteLine(zahl); 
            zahl = MyMath.Calc_kgV(12, 16);
            Console.WriteLine(zahl);
            ShowResult("ggT", 12, 16, MyMath.Calc_ggT(12, 16));

            // Anwendung Aufgabe 8 
            int[] array = {1, 2, 3 };
            int average = MyMath.Calc_average(array);
            Console.WriteLine($"arithmetischer Mittelwert: {average}");

            Console.WriteLine("Wie lang soll deine Array werden?: ");
            int anzahl = ReadInt();
            int average1 = MyMath.Calc_average(ReadValues(anzahl));
            Console.WriteLine($"arithmetischer Mittelwert: {average1}");

            // Aufgabe 6 + 8a
            bool again = true;
            Console.WriteLine("");
            Console.WriteLine("Wilkommen beim ggT & kgV Rechner");
            do
            {
                Console.WriteLine("ggT: 1 oder kgV: 2 ?");
                int methode = ReadInt1();
                Console.WriteLine("Welche ist deine Zahl 1?: ");
                int zahl1 = ReadInt1();
                Console.WriteLine("Welche ist deine Zahl 2?:");
                int zahl2 = ReadInt1();
                string s = (methode == 1 ? "ggT" : "kgV");
                int r = (methode == 1 ? MyMath.Calc_ggT(zahl1, zahl2) : MyMath.Calc_kgV(zahl1, zahl2));
                ShowResult(s, zahl1, zahl2, r);
                Console.WriteLine("Willst du nochmal berechnen? Ja: 1, Nein:2");
                int weiter = ReadInt1();
                if (weiter == 1) 
                {
                    again = true;
                } 
                else 
                {
                    Console.WriteLine("Tschüsss");
                    again = false;
                    break;
                }
            } while (again == true);


        }

        // Aufgabe 5
        private static void ShowResult(string s, int a, int b, int r)
        {
            Console.WriteLine($"{(s == "ggT"?"ggT":"kgV")} von {a} und {b} ist {r}");
        }

        // Aufgabe 4
        // mit Nachfragen
        private static int ReadInt()
        {
            int i = 0;
            do
            {
                Console.WriteLine("Bitte Zahl eingeben");
                string s = Console.ReadLine();
                int.TryParse(s, out i);
            } while (i <= 0);
            Console.WriteLine("danke");
            return i;
        }
        // ohne Fage
        private static int ReadInt1()
        {
            int i = 0;
            string s = Console.ReadLine();
            int.TryParse(s, out i);
            return i;
        }

        // ab Aufgabe 8 
        private static int[] ReadValues(int anzahl)
        {
            int i = 0;
            int[] werte = new int[anzahl];
            while (i < anzahl)
            {
                Console.WriteLine("Zahl: ");
                werte[i++] = ReadInt1();    
            }
            return werte;
        }
    }
}
