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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float baser = float.Parse(base1.Text);
            float alturar = float.Parse(altura1.Text);
            float areatotal = baser * alturar;
            area1.Text = areatotal.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            float baset = float.Parse(base2.Text);
            float alturat = float.Parse(altura2.Text);
            float areatotal2 = (baset * alturat) / 2;
            area2.Text = areatotal2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            float radioc = float.Parse(radio.Text);
            float PI = 3.1416f;
            float areatotal3 = PI * (radioc * radioc);
            area3.Text = areatotal3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            float alturatr = float.Parse(altura3.Text);
            float basemayortr = float.Parse(basemayor.Text);
            float basemenortr = float.Parse(basemenor.Text);
            float areatotal4 = alturatr * ((basemayortr + basemenortr) / 2);
            area4.Text = areatotal4.ToString();
        }
    }
}
