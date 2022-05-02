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
using System.Windows.Threading;

namespace agar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        agario objagario;
        bol objbol;
        DispatcherTimer _tmrbotsen = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            objagario = new agario(cnvcanvas);
            objbol = new bol(cnvcanvas);
            _tmrbotsen.Interval = TimeSpan.FromMilliseconds(1);
            _tmrbotsen.Start();
            _tmrbotsen.Tick += checkbotsingen;
        }

        private void Game_KeyDown(object sender,KeyEventArgs e )
        {
            if(e.Key == Key.Left)
            {
                objagario.Naarlinks();
            }
            if (e.Key == Key.Right)
            {
                objagario.Naarrechts();
            }
            if (e.Key == Key.Up)
            {
                objagario.Naarboven();
            }
            if (e.Key == Key.Down)
            {
                objagario.Naaronder();
            }
        }

        private void checkbotsingen(object sender, EventArgs e)
        {
            objbol.checkagargeraakt(objagario);
        }




    }
}
