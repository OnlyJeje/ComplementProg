using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1 {
    public unsafe class TableauEntiersSurLeTas : IDisposable {

        private int* tab;
        private int tabSize = 0;

        public TableauEntiersSurLeTas() {
            tab = (int *)Memory.Alloc(10 * sizeof(int));
        }
        ~TableauEntiersSurLeTas() {

        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                Memory.Free(tab);
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
                int* tab2 = (int*)Memory.Alloc(Memory.SizeOf(tab) + sizeof(int));
                Memory.Copy(tab, tab2, Memory.SizeOf(tab));
                tab = tab2;
            } 
            tab[tabSize] = nb;
            tabSize++;           
        }

        public void EnleverEntier(int x) {

        }
    }
}
