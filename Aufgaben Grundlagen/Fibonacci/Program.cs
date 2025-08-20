namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int ersteS = 0;
            int zweiteS = 1;
            int nächsteS = 0;
            Console.WriteLine(ersteS);
            while (ersteS < 13)
            {
                nächsteS = ersteS + zweiteS;
                ersteS = zweiteS; 
                zweiteS = nächsteS;
                Console.WriteLine($"{ersteS}");
            }
        }
    }
}
