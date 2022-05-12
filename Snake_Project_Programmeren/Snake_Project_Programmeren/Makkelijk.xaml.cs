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
using System.Windows.Threading;

namespace Snake_Project_Programmeren
{
    /// <summary>
    /// Interaction logic for Makkelijk.xaml
    /// </summary>
    public partial class Makkelijk : Window
    {
        Slang objslang;
        Appel objappel;
        DispatcherTimer _tmrbotsingen = new DispatcherTimer();

        public Makkelijk()
        {
            InitializeComponent();
            objslang = new Slang(cnvcanvas);
            objappel = new Appel(cnvcanvas);
            _tmrbotsingen.Interval = TimeSpan.FromMilliseconds(1);
            _tmrbotsingen.Start();
            _tmrbotsingen.Tick += checkbotsingen;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                objslang.Naarlinks();
            }
            if (e.Key == Key.Right)
            {
                objslang.Naarrechts();
            }
            if (e.Key == Key.Up)
            {
                objslang.Naarboven();
            }
            if (e.Key == Key.Down)
            {
                objslang.Naaronder();
            }
        }

        private void checkbotsingen(object sender, EventArgs e)
        {
            objappel.Opgegeten(objslang);
        }
    }
}
