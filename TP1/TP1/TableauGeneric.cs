using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    //delegate void Del(T str, T str2);
    public unsafe class TableauGeneric<T>
    {
        private delegate bool Del<T>(T str, T str2);
        private int size = 0;
        public static T[] tab;
        private Del<T> d;// = delegate (T str, T str2) { Program<T>.test(tab[0], tab[1]); };
        private Program.Del<string> a;
//        delegate bool handler<T> (T elem1, T elem2);
        //Delegate handler = getsize;

//        public T[] tab;
        public TableauGeneric (Program.Del<T> func)
        {
            tab = new T[10];
            d = func; //delegate(T str, T str2) { Program<T>.test(tab[0], tab[1]); };
        }

/*        public TableauGeneric(Program.Del<string> a)
        {
            // TODO: Complete member initialization
            this.a = a;
        }
        */
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
        public void trions()
        {
            if (this.d(tab[0], tab[1]) == true)
            {

            }
        }

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
