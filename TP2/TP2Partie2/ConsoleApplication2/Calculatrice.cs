using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2Partie2
{
    public class Calculatrice
    {
        // Champs
        private int giResultat = 0;
        private bool gbErreur = false;

        // Propriétés
        public int GiResultat
        {
            get { return giResultat; }
        }

        public bool GbErreur
        {
            get { return gbErreur; }
        }

        //Methode pour faire l'addition de deux entiers
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition de : " + a + " + " + b);
            if ((a >= 0 && a <= 100) && (b >= 0 && b <= 100))
            {
                giResultat = a + b;
                gbErreur = false;
            }
            else
            {
                Console.WriteLine("Addition hors limite : " + a + " + " + b);
                gbErreur = true;
            }
        }

        //Methode pour faire la soustraction de deux entiers
        public void Soustraction(int a, int b)
        {
            Console.WriteLine("Soustraction de : " + a + " - " + b);
            if ((a >= 0 && a <= 100) && (b >= 0 && b <= 100))
            {
                giResultat = b - a;
                gbErreur = false;
            }
            else
            {
                Console.WriteLine("Soustraction hors limite : " + a + " - " + b);
                gbErreur = true;
            }
        }

        //Methode pour faire la multiplication de deux entiers
        public void Multiplication(int a, int b)
        {
            try
            {
                Console.WriteLine("Multiplication de : " + a + " * " + b);
                giResultat = a * b;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur de multiplication : " + a + " * " + b);
            }
        }

        //Methode pour faire la division de deux entiers
        public void Division(int a, int b)
        {
            try
            {
                Console.WriteLine("Division de : " + a + " / " + b);
                giResultat = a / b;
            }
            catch (Exception E)
            {
                if (b == 0)
                {
                    Console.WriteLine("Division par 0 : " + a + " / " + b);
                }
                else
                {
                    Console.WriteLine("Erreur de division :" + a + " / " + b);
                }
            }
        }
    }
}
