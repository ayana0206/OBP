namespace Kundenapplikation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Console.WriteLine("Enter an integer value bigger 0");
            // int inputValue = ReadInt();
            // Console.WriteLine("You entered {0}", inputValue);
            
            // TODO: implement your program
            // Console.WriteLine(teilbar(ReadInt()));
            art();
        }
        static void art()
        {
            Console.WriteLine("Enter 1 for /3,  2 for Fakultät, 3 Fibonacci until ..., 4 for ... Quersumme");
            int tool  = ReadInt();
            if (tool == 1)
            {
                Console.WriteLine($"Von welcher Ganzzahl willst du wissen ob sie durch Drei teilbar ist?");
                int zahl = ReadInt();
                Console.WriteLine($"Die Zahl {zahl} ist durch 3 teilbar: {zahl % 3 == 0}");
            }
            if (tool == 2)
            {
                Console.WriteLine($"Von welcher Ganzzahl willst du die Fakultät wissen?");
                int zahl = ReadInt();
                int fak = 1;
                int i = 1;
                while (i <= zahl) 
                {
                    fak = fak * i;
                    i = i + 1;
                }
                Console.WriteLine($"Zahl {zahl}! hat die Fakultät {zahl}! = {fak}");
            }
            if (tool == 3)
            {
                Console.WriteLine($"Bis zu welcher Ganzzahl willst du die Fibonacci Folge wissen?");
                int zahl = ReadInt();
                int ersteS = 0;
                int zweiteS = 1;
                int nächsteS = 0;
                Console.WriteLine(ersteS);
                while (zweiteS <= zahl)
                {
                    nächsteS = ersteS + zweiteS;
                    ersteS = zweiteS;
                    zweiteS = nächsteS;
                    Console.WriteLine($"{ersteS}");
                }
            }
            if (tool == 4) 
            {
                Console.WriteLine("mach selber!");
            }

        }
        static int ReadInt()
        {
            int i;
            do
            {
                string s = Console.ReadLine();
                int.TryParse(s, out i);
            } while (i <= 0);
            return i;
        }

        // TODO: implement your functions

    }
}
