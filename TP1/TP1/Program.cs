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
            
        }
    }
}