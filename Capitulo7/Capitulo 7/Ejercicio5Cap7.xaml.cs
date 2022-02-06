using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo7.Capitulo_7
{
    /// <summary>
    /// Interaction logic for Ejercicio5Cap7.xaml
    /// </summary>
    /*
        5-Hacer un programa que funcione como
    una agenda telefónica y que guarde el
    nombre de la persona y su número
 */
    public partial class Ejercicio5Cap7 : Window
    {
          private List<string> NOMBRE = new List<string>();
          private List<long> TELEFONO= new List<long>();
        public Ejercicio5Cap7()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            long numeroo=long.Parse(telefono.Text);
            NOMBRE.Add(nombre.Text);
            TELEFONO.Add(numeroo);
            telefono.Text = " ";
            nombre.Text = " ";
        }
         private void Contacto_Click(object sender, RoutedEventArgs e)
        {
            pantalla.Items.Clear();
             for(int i=0; i <NOMBRE.Count; i++)
            {
               pantalla.Items.Add(NOMBRE[i]);
               pantalla.Items.Add(TELEFONO[i]);
               
                 
            }
         
        }
    }
}
