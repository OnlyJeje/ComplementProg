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
        List<string> Display = new List<string>();
        public Form1() {
            InitializeComponent();

        }

        public void ManageAssembly(Type t) {

            /* Get Assembly Name*/
            Display.Add("Nom: \n    " + t.Name);

            Display.Add("\nAttributs personnalisés:");
            /* Get assembly custom attribute and add to list */
            foreach (var elemen in Attribute.GetCustomAttributes(t).ToArray()) {
                Display.Add("   " + elemen);
            }

            /* Get assembly type name */
            Display.Add("\nType : \n  " + t.BaseType.Name);

            /* Get assembly's modifier access */
            if (t.IsPublic)
                Display.Add("\nModificateur d'accès : \n    Public ");
            else if (t.IsNotPublic)
                Display.Add("\nModificateur d'accès : \n    Private ");
            else if (t.IsAbstract)
                Display.Add("\nModificateur d'accès : \n    Abstract ");

            Display.Add("\nFields :");
        }


        public void ManageField(Type t) {
            FieldInfo[] field = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var f in field) {
                Display.Add("   Nom: " + f.Name);
                Display.Add("   Type : " + f.FieldType.Name);

                /* Get field 's access modifier */
                if (f.IsPublic)
                    Display.Add("\nModificateur d'accès : \n    Public ");
                else if (f.IsPrivate)
                    Display.Add("\nModificateur d'accès : \n    Private ");
                else if (f.IsFamily)
                    Display.Add("\nModificateur d'accès : \n    Protected ");

                foreach (var attr in Attribute.GetCustomAttributes(f).ToArray()) {
                    Display.Add("   Attribut:" + attr.ToString());
                }
            }
        }

        public void ManageMethod(Type t) {
            Display.Add("Méthodes: ");
            /* Get assembly method and add to list */
            MethodInfo[] method = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (var m in method) {
                Display.Add("   Nom : " + m.Name);
                Display.Add("   Type de retour: " + m.ReturnType.Name);

                /* Get method 's access modifier */
                if (m.IsPublic)
                    Display.Add("\nModificateur d'accès : \n    Public ");
                else if (m.IsPrivate)
                    Display.Add("\nModificateur d'accès : \n    Private ");
                else if (m.IsFamily)
                    Display.Add("\nModificateur d'accès : \n    Protected ");
                foreach (var attr in Attribute.GetCustomAttributes(m).ToArray()) {
                    Display.Add("       Attribut:" + attr.ToString());
                }

                Display.Add("   Paramètres: ");
                /* Get method parameter and add to list */
                foreach (var param in m.GetParameters()) {
                    Display.Add("       Nom: " + param.Name);
                    Display.Add("       Type: " + param.ParameterType.Name + "\n");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e) {


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Exe File (.exe) |*.exe";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();

            try {
                AssemblyName assembly = AssemblyName.GetAssemblyName(openFileDialog.FileName);
                Assembly file;

                file = Assembly.LoadFrom(openFileDialog.FileName);

                    foreach(Type t in file.GetTypes()) {

                        ManageAssembly(t);
                        /* Get assembly fields and add to list */
                        ManageField(t);
                        ManageMethod(t);

                        Display.Add("\n-------------------------------------------------\n");
                }

                    richTextBox1.Lines = Display.ToArray();
            }
            catch (BadImageFormatException) {
                MessageBox.Show("Ce fichier n'est pas un assembly .Net valide.");
            }
        }
    }
}
