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

                    foreach(Type t in file.GetTypes()) {

                        /* Get Assembly Name*/
                        Display.Add("Nom: \n    " + t.Name);

                        Display.Add("\nAttributs personnalisés:");
                        /* Get assembly custom attribute and add to list */
                        foreach (var elemen in Attribute.GetCustomAttributes(t).ToArray()) {
                            Display.Add("   " + elemen);
                        }

                        /* Get assembly type name */
                        Display.Add("\nType : \n  " + t.BaseType.Name);

                        Display.Add("\nFields :");
                        /* Get assembly fields and add to list */
                        FieldInfo[] field = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic |
                   BindingFlags.Instance | BindingFlags.Static);
                        foreach (var f in field) {
                            Display.Add("   Nom: " + f.Name);
                            Display.Add("   Type : " + f.FieldType.Name);
                            
                            foreach (var attr in Attribute.GetCustomAttributes(f).ToArray()) {
                                Display.Add("   Attribut:" + attr.ToString());
                            }                           
                        }

                        Display.Add("Méthodes: ");
                        /* Get assembly method and add to list */
                        MethodInfo[] method = t.GetMethods(
                   BindingFlags.Public | BindingFlags.NonPublic |
                   BindingFlags.Instance | BindingFlags.Static);
                        foreach (var m in method){
                            Display.Add("   Nom : " + m.Name);
                            Display.Add("   Type de retour: " + m.ReturnType.Name);
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
