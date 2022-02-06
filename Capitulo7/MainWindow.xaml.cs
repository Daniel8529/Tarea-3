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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Capitulo7.Capitulo_7;

namespace Capitulo7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void ejercicio1C7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio1cap7 ejer1c7 = new Ejercicio1cap7();
            ejer1c7.Show();
        }

        private void ejercicio2c7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio2 ejer2 = new Ejercicio2();
            ejer2.Show();
        }

        private void Ejercicio5c7_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap7 ejer5c7 = new Ejercicio5Cap7();
            ejer5c7.Show();
        }
    }
}
