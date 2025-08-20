using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Rectangle
    {
        private readonly string name = "Anna";
        // private int width = 33;
        // private int hight;
        private Color color = Color.Aquamarine;
        private Color fillcolor;


        // optimal 
        public int Width { get; set; }
        public int Height { get; private set; }


        public int Area
        {
            get
            {
                return Width * Height; // in UML mit / schreiben da 
            }
        }
        // gleich wie 
        // public int Area => Width * Height


        /*public int getWidth()
        {
            return this.width;
        }
        public int getHight()
        {
            return this.hight;
        }*/

        

        /* ->  beim Setter einfach verändern muss nichts zurückgeben !!
         
        public void setWidth(int width)
        {
           this.width = width;
        }
        public void setHight(int hight)
        {
           this.hight = hight;
        }*/ 


    }
}
