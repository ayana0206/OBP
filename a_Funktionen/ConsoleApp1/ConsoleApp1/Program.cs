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
        }

        private static void ShowResult(string s, int a, int b, int r)
        {
            Console.WriteLine($"{(s == "ggT"?"ggT":"kgV")} von {a} und {b} ist {r}");
        }
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
    }
}
