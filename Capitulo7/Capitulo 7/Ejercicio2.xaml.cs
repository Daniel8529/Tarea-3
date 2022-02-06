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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>

    /*
        2-Hacer un programa que funcione como un
    diccionario, con palabra y definición,
    usando el Hashtable.
    */
    public partial class Ejercicio2 : Window
    {
        Hashtable tabla = new Hashtable();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            tabla.Add(palabra.Text,definicion.Text);
            palabra.Text="";
            definicion.Text="";
        }

        private void ver_Click(object sender, RoutedEventArgs e)
        {
           
            foreach(DictionaryEntry dato in tabla)
            {
                pantalla.Items.Add(dato.Key);
               pantalla.Items.Add(dato.Value);
            }

            
            
        }
    }
}
