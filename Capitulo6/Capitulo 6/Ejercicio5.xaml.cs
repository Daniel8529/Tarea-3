using System;
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

namespace Capitulo6.Capitulo_6
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
     /*
        5 Crear un programa que pase un arreglo
    como parámetro a una función

    */
    public partial class Ejercicio5 : Window
    {
        public static int Cantidad=3;
     
        private int[] calificaciones = new int[Cantidad];
        private int indice = 0;
        public Ejercicio5()
        {
            InitializeComponent();
        }
       
       
        private void agregar_Click(object sender, RoutedEventArgs e)
        {
          
            Agregar();
        }

      
         private void Agregar()
        {
            
          
            int cali =int.Parse(calificacion.Text);
            
            if(indice < Cantidad)
            {
                calificaciones[indice] = cali;
                calificacion.Text = " ";
                indice = indice + 1;
               if(indice==Cantidad){
                   Calcular(calificaciones);
               }
                
            }
            else
            {
                MessageBox.Show("No se permite mas calificacion", "Calificaciones llenas");
            }
            
            
           

        }

        private void Calcular(int [] calificacionessss)
        {
                float suma = 0;
            float promedio=0;                                                 
            int mayor = 0;
            int menor=0;
           
            int i;
            for(i=0; i < calificacionessss.Length; i++)
            {
                suma+=calificacionessss[i];
                
                
             
                mayor=calificacionessss.Max();
              
                menor=calificacionessss.Min();
                 
            }
            
             promedio=suma/i;
             pantalla.Items.Add("El mayor es "+mayor);
             pantalla.Items.Add("El menor es "+menor);
             pantalla.Items.Add("El promedio es "+promedio);
        
        }
    }
}
