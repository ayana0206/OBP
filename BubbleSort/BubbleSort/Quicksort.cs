using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Quicksort
    {
        private IList<int> listToSort;

        Quicksort(IList<int> listToSort)
        {
            this.listToSort = listToSort;
            Sort(listToSort, listToSort[0], listToSort.Count - 1);
        }
        private void Sort(IList<int> array, int start, int end)
        {
            if (end <= start) return; // best case

            int pivot = partition(array, start, end);
            Sort(array, start, pivot-1);
            Sort(array, pivot + 1, end);

        }

        private int partition(IList<int> array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j<= end-1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            i++;
            int temp = array[i];
            array[i] = array[end];
            array[end] = temp;

            return i;
        }

       

    }
}
