using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Partie2
{
    class Principal
    {
        static void Main(string[] args)
        {
            Calculatrice monCalc = new Calculatrice();

            monCalc.Addition(1, 2);
            AfficherResultat(monCalc);

            monCalc.Division(1, 2);
            AfficherResultat(monCalc);

            monCalc.Multiplication(1, 2);
            AfficherResultat(monCalc);

            monCalc.Soustraction(1, 2);
            AfficherResultat(monCalc);

            Console.ReadKey();
        }

        static void AfficherResultat(Calculatrice argCalc)
        {
            Console.WriteLine("Résultat = " + argCalc.GiResultat);
            Console.WriteLine("Erreur   = " + argCalc.GbErreur);
            Console.WriteLine();
        }
    }
}
