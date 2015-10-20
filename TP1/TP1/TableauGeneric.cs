using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{

    public unsafe class TableauGeneric<T>
    {
        public int size = 0;
        public static T[] tab;
        private Program.Del<T> delegateFunction;

        public TableauGeneric (Program.Del<T> func)
        {
            tab = new T[10];
            delegateFunction = func;
        }
        public TableauGeneric()
        {
        }
        public void ajouterElement(T elem)
        {
            if (size >= 10)
            {
                T[] tab2 = new T[size + 1];
                tab.CopyTo(tab2, 0);
                tab = tab2;
            }
            tab[size] = elem;
            size++;
        }

        public void supprimerElement(int index)
        {
            T[] tab2 = new T[size - 1];
            int i = 0;
            while (i < index)
            {
                tab2[i] = tab[i];
                i++;
            }
            i++;
            while (i < tab.Length)
            {
                tab2[i - 1] = tab[i];
                i++;
            }
            tab = tab2;
            size--;
        }
        public T recupererElement(int index)
        {
            return (tab[index]);
        }
        public void trierElement()
        {
            int i = 1;
            bool change = true;
            T swap;
            while (change == true)
            {
                change = false;
                i = 1;
                while(i < size)
                {
                    if (delegateFunction(tab[i - 1], tab[i]) == true)
                    {
                        swap = tab[i - 1];
                        tab[i - 1] = tab[i];
                        tab[i] = swap;
                        change = true;
                    }
                    i++;
                }
            }
        }

        public bool obtenirTaille(T elem, T elem2)
        {

            if (elem.ToString().Length > elem2.ToString().Length)
                return (true);
            else
                return (false);
        }

        public string reflexion()
        {
            string knowledge;
            knowledge = "Type : ";
            knowledge += (tab[0].GetType()).ToString();
            knowledge += "\nAssembly : ";
            System.Reflection.Assembly info = (tab[0].GetType()).Assembly;
            knowledge += info.ToString();
            return (knowledge);
        }

        
    }
}
