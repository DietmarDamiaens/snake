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

namespace Snake_Project_Programmeren
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

        private void Makkelijk_Click(object sender, RoutedEventArgs e)
        {
            Makkelijk objMakkelijk = new Makkelijk();
            objMakkelijk.Show();
        }

        private void Normaal_Click(object sender, RoutedEventArgs e)
        {
            Normaal objNormaal = new Normaal();
            objNormaal.Show();
        }

        private void Moeilijk_Click(object sender, RoutedEventArgs e)
        {
            Moeilijk objMoeilijk = new Moeilijk();
            objMoeilijk.Show();
        }
    }
}
