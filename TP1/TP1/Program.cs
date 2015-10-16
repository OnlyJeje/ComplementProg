using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
    unsafe class Program {
        static void Main(string[] args) {
            TableauEntiersSurLeTas tango = new TableauEntiersSurLeTas();

            tango.AjoutEntier(0);
            tango.AjoutEntier(1);
            tango.AjoutEntier(2);
            tango.AjoutEntier(3);
            tango.AjoutEntier(4);
            tango.AjoutEntier(5);
            tango.AjoutEntier(6);
            tango.AjoutEntier(7);

            tango.AjoutEntier(8);
            tango.AjoutEntier(9);
            tango.AjoutEntier(10);
            tango.AjoutEntier(11);
            tango.AjoutEntier(12);
            tango.AjoutEntier(13);
            tango.AjoutEntier(14);
            tango.AjoutEntier(15);
            tango.AfficherTableau();
            tango.Dispose();
        }
    }
}
