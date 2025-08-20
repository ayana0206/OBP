namespace Fakultät
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int f = 7;
            int i = 1;
            int r = 1;
            while (i <= f)
            {
                r = r * i;
                i = i + 1;
            }
            Console.WriteLine($"Fakultät von {f} ist {r}");


        }
    }
}
