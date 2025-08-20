using System;
using System.Collections.Generic;
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
    }
}
