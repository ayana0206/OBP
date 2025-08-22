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
        public string nameV { get; private set; }
        private List<Mannschaft> mannschaftsList = new List<Mannschaft>();

        // Konstruktor
        public Verein(string nameVerein, string namePräsident)
        {
            this.nameV = nameVerein; 
            Console.WriteLine($"Der Verein {nameVerein} wurde erstellt. ");
            this.setPräsident(namePräsident);
        }


        // Methode
        public void setPräsident(string nameP)
        {
            Praesident präsident = new Praesident(nameP);
            Console.WriteLine($"Der Präsident des Vereins {nameV} ist {nameP}. ");
        }

        public void setMannschaft(string Motto, List<string> nameFS, List<string> namenT)
        {
            Mannschaft mannschaft = new Mannschaft(Motto, nameFS, namenT);
            Console.WriteLine($"Die neue Mannschaft des Vereins {nameV} heisst {Motto}. ");

        }
        public void addMannschaft(Mannschaft Mannschaft)
        {
            if (mannschaftsList.Count < 10)
            {
                mannschaftsList.Add(Mannschaft);
            }
            
        }
        public



    }
}
