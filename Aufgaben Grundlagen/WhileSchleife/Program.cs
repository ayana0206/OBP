namespace WhileSchleife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i = 1;
            
            while (i < 201)
            {
                Console.WriteLine($"Zahl {i} ist teilbar durch 3: {i%3 == 0}");
                i = i + 1;
            }

        }
    }
}
