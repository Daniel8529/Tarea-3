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
    /// Interaction logic for Ejercicio1cap7.xaml
    /// </summary>

        /* 
        1-Hacer el programa que calcula el
    promedio, calificación máxima y mínima
    de un salón de clases usando el ArrayList
    
    */

    public partial class Ejercicio1cap7 : Window
    {
        private List<float> lista = new List<float>();
        public Ejercicio1cap7()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {
            float numero = float.Parse(calificacion.Text);
            lista.Add(numero);
            calificacion.Text = "";
        }



        private void Imprimir_Click(object sender, RoutedEventArgs e)
        {
            float suma = 0;
            float promedio = 0;
            float mayor = 0;
            float menor = 0;

            int i;
            for (i = 0; i < lista.Count; i++)
            {
                suma += lista[i];



                mayor = lista.Max();
                menor = lista.Min();



            }

            promedio = suma / i;
            pantalla.Items.Add("El mayor calificacion es " + mayor);
            pantalla.Items.Add("El menor calificacion es " + menor);
            pantalla.Items.Add("El promedio es " + promedio);


        }
    }
}
