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
        public int Nickname { get; }

        // Eine automatisch implementierte, read-write Eigenschaft.
        
        // Eine automatisch implementierte, write-only Eigenschaft.

    }
}
