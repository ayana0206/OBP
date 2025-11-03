namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = [ 4, 2, 7, 10, 5, 1, 5, 2, 0];

            var sorter = new BubbleSort(list);

            foreach (int i in sorter.Sort())
            {
                Console.WriteLine(i);
            }

            

        }
    }
}
