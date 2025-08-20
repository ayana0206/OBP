namespace Quersumme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Die grösste Zahl ist {GebeMaxAus(2, 5, 3)}");
        }
        static int GebeMaxAus(int zahl1, int zahl2, int zahl3)
        {
            if (zahl1 > zahl2)
            {
                if (zahl1 > zahl3)
                {
                    return zahl1;
                }
                else
                {
                    return zahl3;
                }
            }
            else
            {
                if (zahl2 > zahl3)
                {
                    return zahl2;
                }
                else
                {
                    return zahl3;
                }
            }
        
        }
    }
}