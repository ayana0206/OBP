namespace Schaltjahr_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guten Tag, Wilkommen beim Schaltjahrrechner");
            string go = "Y";
            bool isLeapyear = true;
            while (go == "Y")
            {
                Console.WriteLine("Von welchem Jahr willst du wissen ob es ein Schaltjahr ist, gebe sie ein: ");
                int jahr = Convert.ToInt32(Console.ReadLine());
                if (jahr % 4 == 0)
                {
                    if (jahr % 100  == 0) 
                    { 
                        if(jahr % 400 == 0)
                        {
                            isLeapyear = true;
                        }
                        else
                        {
                            isLeapyear = false;
                        }
                    }
                    else
                    {
                        isLeapyear = true;
                    }
                }
                else 
                { 
                    isLeapyear = false; 
                }
                Console.WriteLine($"Das Jahr {jahr} ist {(isLeapyear ? "ein":"kein")} Schaltjahr.");
                Console.WriteLine("Willst du von einem weiterern Jahr wissen, ob es ein Schlatjahr ist?");
                Console.WriteLine("'Y' oder 'N'");
                go = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Vielen Dank und bis zum nächsten mal :)");
        }
    }
}
