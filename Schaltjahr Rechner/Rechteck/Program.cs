namespace Rechteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Rechteck rechteck = new Rechteck();
            Rechteck rechteck1 = new Rechteck();

            rechteck.Turn(10);
            Console.WriteLine(rechteck.Length());


            rechteck.SetLength(10);
            Console.WriteLine(rechteck.Length());

        
            Console.WriteLine(rechteck1.Length());


        }
    }
}
