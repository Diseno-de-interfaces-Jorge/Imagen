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

namespace Imagen
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

        private void AltaOpacidad_Checked(object sender, RoutedEventArgs e)
        {
            ImagenStarWars.Opacity = 1; //Error Null "System.NullReferenceException"
        }

        private void Relleno_AjusteChecked(object sender, RoutedEventArgs e)
        {
            ImagenStarWars.Stretch = Stretch.Fill;
        }

    }
    
}
