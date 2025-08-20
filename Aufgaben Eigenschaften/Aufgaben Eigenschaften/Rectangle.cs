using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben_Eigenschaften
{
    internal class Rectangle
    {
        public Rectangle() 
        { 

        }
        // Eine selber implementierte, read-only Eigenschaft
        private string name;
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
        }

        // Eine selber implementierte, read-write Eigenschaft.
        private int height;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        // Eine selber implementierte, write-only Eigenschaft.
        private int width;
        public int Width
        {
            set
            {
                width = value;
            }
        }
        // Eine automatisch implementierte, read-only Eigenschaft.
        public string Nickname { get; private set; } // setter könnte auch ganz fehlen ...

        // Eine automatisch implementierte, read-write Eigenschaft.
        public string Description { get; set; }
        
        // Eine automatisch implementierte, write-only Eigenschaft. 
        public int note { private get; set; } // nicht möglich ???

    }
}
