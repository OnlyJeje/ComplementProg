using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
    unsafe class Program {
        static void Main(string[] args) {

            /* Tavail sur TableauEntiersurleTas() */

            TableauEntiersSurLeTas tango = new TableauEntiersSurLeTas();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++) {
                tango.AjoutEntier(rnd.Next(25));
            }
            tango.EnleverEntier(10);
            tango.Trier();
            tango.AfficherTableau();
            tango.Dispose();

            TableauGeneric<string> banjo = new TableauGeneric<string>();
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("boum");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            banjo.addElement("plop");
            Console.WriteLine(banjo.getElem(6));
            banjo.deleteElement(6);
            Console.WriteLine(banjo.getElem(6));
            Console.WriteLine(banjo.reflexion());
            Console.WriteLine("Fin"); 
        }
    }
}