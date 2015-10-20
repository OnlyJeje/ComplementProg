using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
    unsafe class Program {
       // private delegate void Del<T>(T str, T str2);
        public delegate bool Del<B>(B item, B item2);
//        public static void Notify<T>(T test) { }

        public static bool test<B>(B str, B str2)
        {
            return(true);
        }
        static void Main<T>(string[] args) {
           
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
            Del<string> a = delegate(string item, string item2)
            {
                if (item.Length > item2.Length)
                    return (true);
                else
                    return (false);
            };
                //delegate(T str, T str2) { Program<T>.test(tab[0], tab[1]); };
            TableauGeneric<string> banjo = new TableauGeneric<string>(a);
//            Del<T> func = delegate(T str, T str2) { test<T>(banjo[0], banjo[1]); };
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