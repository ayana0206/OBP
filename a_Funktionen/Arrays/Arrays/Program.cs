namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];

            int[] array1 = { 1, 2, 3 };

            Console.WriteLine(array.Length);
            Console.WriteLine(array1.Length);

            string[] array2 = { "Hallo", "Hi", "Bonjour" };
            Console.WriteLine(array2.Length);
            Console.WriteLine(array2[1]);        
        }
    }
}
