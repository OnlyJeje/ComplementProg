using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
    public unsafe class TableauEntiersSurLeTas : IDisposable {

        private int[] tab;
        private int tabSize = 0;

        public TableauEntiersSurLeTas() {
            tab = new int[10];
        }
        ~TableauEntiersSurLeTas() {

        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                System.GC.Collect();
            }
        }

        public void AfficherTableau() {
            for (int i = 0; i <= tabSize - 1; i++) {
                Console.WriteLine("Element "+ i + " = " + tab[i]);
            }
            Console.ReadKey();
        }

        public void AjoutEntier(int nb) {
            
           if ((tabSize > 9))
           {
               int* tab2 = (int*)Memory.Alloc(tab.Length * sizeof(int) + sizeof(int));
               fixed (int* a = tab) Memory.Copy(a, tab2, Memory.SizeOf(tab2));
               int[] res = new int[tabSize + 1];
               fixed (int* p = res) Memory.Copy(tab2, p, Memory.SizeOf(tab2));
               tab = res;
               Memory.Free(tab2);
           }
            tab[tabSize] = nb;
            tabSize++;                      
        }

        public void EnleverEntier(int x) {
            int[] res = new int[tabSize - 1];
            int j = 0;

            for (int i = 0; i < tabSize ; i++) {
                res[j] = tab[i];
                if (i == x)
                    i++;
                j++;
            }
            tabSize--;
            tab = res;
        }

        public void Trier() {
            Array.Sort(tab);
        }

        public int NbrElement() {
            return tab.Length;
        }

        public int ElementAtX(int x) {
            return (tab[x]);
        }
    }
}
