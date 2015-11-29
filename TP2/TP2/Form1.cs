using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace TP2 {
    public partial class Form1 : Form {
        enum test {
            A,
            B,
            C
        };
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {


            List<string> Display = new List<string>();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Exe File (.exe) |*.exe";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            try {
                AssemblyName assembly = AssemblyName.GetAssemblyName(openFileDialog.FileName);
                Assembly file;

                file = Assembly.LoadFrom(openFileDialog.FileName);
                int i = 0;
                    foreach(Type t in file.GetTypes()) {
                        var attr = t.CustomAttributes;
                        var name = t.Name;


                        Display.Add(t.ToString());
                }
                    richTextBox1.Lines = Display.ToArray();
            }
            catch (BadImageFormatException) {
                MessageBox.Show("Ce fichier n'est pas un assembly .Net valide.");
            }
        }
    }
}
