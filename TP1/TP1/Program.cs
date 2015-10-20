using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP1 {
    public unsafe class Program {

        public delegate bool Del<B>(B item, B item2);
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
            Del<string> a = delegate(string item, string item2)
            {
                if (item.Length > item2.Length)
                    return (true);
                else
                    return (false);
            };

            /* Travail sur TableauGeneric<> */


            TableauGeneric<string> banjo = new TableauGeneric<string>(a);
            banjo.ajouterElement("plopiti");
            banjo.ajouterElement("plop");
            banjo.ajouterElement("plopou");
            banjo.ajouterElement("plopitijvy;");
            banjo.ajouterElement("plopojol");
            banjo.ajouterElement("plopouvftky");
            banjo.ajouterElement("plopitikdkdkdkdkdkd");
            banjo.ajouterElement("plopddkssùùùq");
            banjo.ajouterElement("plopoudfghj");
            banjo.ajouterElement("p");
            banjo.ajouterElement("ploplkjhgfdertylkmlml,m,m,m");
            banjo.ajouterElement("pl");
            banjo.ajouterElement("plopkdkdlzsmsmsmsmsmsmsmmsldodleiti");
            banjo.ajouterElement("plo");
            banjo.ajouterElement("plopoukoeeoeodkoedkoekfoekfoekforkorkoror");
            banjo.supprimerElement(9);
            banjo.trierElement();
            for (int i = 0; i < 14; i++)
            {
                Console.WriteLine(banjo.recupererElement(i));
            }
            Console.WriteLine(banjo.reflexion());
            Directory.CreateDirectory("C:\\tmp");
            XmlSerializer xs = new XmlSerializer(typeof(TableauGeneric<string>));
            using (StreamWriter wr = new StreamWriter(File.Create("C:\\tmp\\Serialisation_XML_TP1_Jeremy_&_Adrien.XML")))
            {
                xs.Serialize(wr, banjo);
            }
                Console.ReadKey();
        }
    }
}