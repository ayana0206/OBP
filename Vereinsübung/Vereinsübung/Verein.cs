using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vereinsübung
{
    internal class Verein
    {
        public Verein(string nameVerein, string namePräsident)
        {
            this.nameV = nameVerein; 
            Console.WriteLine($"Der Verein {nameVerein} wurde erstellt. ");
            this.setPräsident(namePräsident);
        }

        public string nameV { get; private set; }
        
        public void setPräsident(string nameP)
        {
            Präsident präsident = new Präsident(nameP);
            Console.WriteLine($"Der Präsident des Vereins {nameV} ist {nameP}. ");
        }

        public void addMannschaft(string nameMannschaft)
        {
            Mannschaft mannschaft = new Mannschaft(nameMannschaft);
            Console.WriteLine($"Die neue Mannschaft des Vereins {nameV} heisst {nameMannschaft}. ");
        }
    }
}
