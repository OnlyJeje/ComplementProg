using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{

    public unsafe class TableauGeneric<T>
    {
        private int size = 0;
//        delegate bool handler<T> (T elem1, T elem2);
        //Delegate handler = getsize;

        public T[] tab;
        public TableauGeneric ()
        {
            tab = new T[10];
        }

        public void addElement(T elem)
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

        public void deleteElement(int index)
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
        }
        public T getElem(int index)
        {
            return (tab[index]);
        }
      /*  public void trions()
        {
            if (this.handler(tab[0], tab[1]) == true)
            {

            }
        }*/

        public bool getsize(T elem, T elem2)
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
