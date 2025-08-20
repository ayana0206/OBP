using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
            z = a * b / Calc_ggT(a,b);
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
            return Calc_ggT_r(b, a%b);
                                
        }
        
        // Aufgabe 8a
        public static int Calc_average(int[] array)
        {
            int sum = 0;
            foreach (int i in array) 
            {
                sum += i;
            }
            return sum/array.Length;
        }

        // Aufgabe 8b
        public static int Calc_lowest(int[] array)
        {
            int lowest = 0;
            foreach (int i in array)
            { 
                
            }
            return lowest;       
        }
    }
}
