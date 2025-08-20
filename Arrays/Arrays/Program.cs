namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int[] array1 = { 1, 2, 3 };

            Console.WriteLine(array.Length);
            Console.WriteLine(array1.Length);

            string[] array2 = { "Hallo", "Hi", "Bonjour" };
            Console.WriteLine(array2.Length);
            Console.WriteLine(array2[1]);        
        }
    }
}
