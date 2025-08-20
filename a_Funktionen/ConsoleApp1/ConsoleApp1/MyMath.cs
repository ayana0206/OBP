using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyMath
    {
        // Aufgabe 3
        public static int Calc_kgV(int a, int b)
        {
            int z = 0;
            z = a * b / Calc_ggT(a, b);
            return z;
        }

        // Aufgabe 2
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        // Aufgabe 7
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Calc_ggT_r(b, a % b);

        }

        // Aufgabe 8a
        public static int Calc_average(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum / array.Length;
        }

        // Aufgabe 8b
        public static int Calc_lowest(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            if (array.Length > 1)
            {
                int a = array[0];
                int b = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (a < b)
                    {
                        b = array[i];
                    }
                    else
                    {
                        a = b;
                        b = array[i];
                    }
                }
                return a;
            }
            return -1;

        }
        // alternative zu Aufgabe 8b
        public static int GetMin(int[] array)
        {
            int min = int.MaxValue;
            foreach (int wert in array)
            {
                if (wert < min)
                {
                    min = wert;
                }
            }
            return min;
        }
        // Aufgabe 8c
        public static int Calc_highest(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }
            if (array.Length > 1)
            {
                int a = array[0];
                int b = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (a > b)
                    {
                        b = array[i];
                    }
                    else
                    {
                        a = b;
                        b = array[i];
                    }
                }
                return a;
            }
            return -1;
        }
        // alternative zu aufgabe 8c 
        public static int GetMax(int[] array)
        {
            int max = int.MinValue;
            foreach (int wert in array)
            {
                if (wert > max)
                {
                    max = wert;
                }
            }
            return max;
        }
    }
}
