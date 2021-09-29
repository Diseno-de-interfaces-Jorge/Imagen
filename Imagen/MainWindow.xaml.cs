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
            AltaOpacidadRadioButton.IsChecked = true;
            RellenoAjusteRadioButton.IsChecked = true;
        }

        private void AltaOpacidadRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 1;
        }

        private void MediaOpacidadRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 0.6;
        }


        private void BajaOpacidadRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 0.3;
        }

        private void RellenoRadioButton_AjusteChecked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.Fill;
        }

        private void UniformeAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.UniformToFill;
        }

        private void SinAjusteRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.None;

        }
    }
    
}
