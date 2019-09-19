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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            Botoncito.Click += Botoncito_Click;
        }

        private void Botoncito_Click(object sender, RoutedEventArgs e)
        {
            lblQchao.Text = "K- chika";
            lblQchao.FontSize = 42;
            lblQchao.Foreground = Brushes.Green;
            lblQchao.Background = Brushes.Blue;
        }

        private void Botoncito2_Click(object sender, RoutedEventArgs e)
        {
            lblQchao.Text = "yyyyy ya bailaste morro";
            lblQchao.FontSize = 69;
            lblQchao.Foreground = Brushes.Red;
            lblQchao.Background = Brushes.Black;
        }

        private void Botoncito3_Click(object sender, RoutedEventArgs e)
        {
            lblQchao.Text = "Has sido salvado y bendecido con etsito";
            lblQchao.FontSize = 54;
            lblQchao.Foreground = Brushes.Gold;
            lblQchao.Background = Brushes.LightBlue;
        }
    }
}
