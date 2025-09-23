using System.Diagnostics;

namespace Fakultät
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  // Fakultät 
            Console.WriteLine(Factorial(5));
            Console.WriteLine(FactorialRecursiv(2));
            */

            /* // Addition als Multiplikation 
            Console.WriteLine(MultiplicationAdd(1, 5)); */


            /* // Fibonacci
            Console.WriteLine(Fibonacci(40));
            Console.WriteLine(FibonacciRec(40));*/

            int n = 45;

            // Zeitmessung für rekursive Version
            Stopwatch sw1 = Stopwatch.StartNew();
            int resultRec = FibonacciRec(n);
            sw1.Stop();
            Console.WriteLine($"FibonacciRec({n}) = {resultRec}, Zeit: {sw1.Elapsed.TotalSeconds} s");

            // Zeitmessung für iterative Version
            Stopwatch sw2 = Stopwatch.StartNew();
            int resultIter = Fibonacci(n);
            sw2.Stop();
            Console.WriteLine($"Fibonacci({n}) = {resultIter}, Zeit: {sw2.Elapsed.TotalSeconds} s");


        }
        public static int FibonacciRec(int zahl)
        {
            if (zahl == 1 || zahl == 2)
            {
                return 1;
            }
            return FibonacciRec(zahl - 1) + FibonacciRec(zahl - 2);
        }
        public static int Fibonacci(int zahl)
        {
            int ersteS = 0;
            int zweiteS = 1;
            int nächsteS = 0;
            for (int i = 0; i < zahl; i++)
            {
                nächsteS = ersteS + zweiteS;
                ersteS = zweiteS;
                zweiteS = nächsteS;
            }
            return ersteS;
        }
        public static int MultiplicationAdd(int f1, int f2)
        {
            if (f2 == 1)
                return f1;
            return f1 + MultiplicationAdd(f1, f2 - 1);
        }
        public static int Factorial(int n)
        {
            var result = 1; 

            for (var i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
        public static long FactorialRecursiv(long n)
        {
            if (n == 0)
            {
                return 1;
            }
                return n * FactorialRecursiv(n - 1);
        }
    }
}
