using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck
    {
        private Color color;
        private Color fillcolor;
        private int length = 7;
        private int width;

        public void Turn(int degree) 
        {
            Console.WriteLine("turn");
        }
        public void Blink(Color color) 
        { 
            Console.WriteLine("blink"); 
        }
        public int Length()
        {
            return length;
        }
        public void SetLength(int length)
        {
            this.length = length;
        }

    }
}
