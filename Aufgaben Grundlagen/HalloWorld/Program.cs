namespace HalloWorld
{
    internal class Program
    {
        private static bool Vergleichsoperatoren;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Vergleichsoperatoren");
            Console.Write(2 == 3);
            Console.Write(2 != 3);
            Console.Write(2 < 3);
            Console.Write(2 > 3);
            Console.Write(2 <= 3);
            Console.Write(2 >= 3);
            Console.Write(3 <= 3);
            Console.Write(3 >= 3);
            Console.WriteLine();
            Console.WriteLine("Arithmetische Operatoren");
            Console.Write(22 + 8);
            Console.Write(22 - 8);
            Console.Write(22 * 8);
            Console.Write(22 / 8);
            Console.Write(22 % 8);


        }
    }
}
