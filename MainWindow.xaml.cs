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

namespace Tema2_TamanyoTexto
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

        private void Pequeño_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => texto_TextBlock.FontSize = 36;

        private void Mediano_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => texto_TextBlock.FontSize = 48;

        private void Grande_RadioButton_Checked(object sender, RoutedEventArgs e) 
            => texto_TextBlock.FontSize = 72;
    }
}
