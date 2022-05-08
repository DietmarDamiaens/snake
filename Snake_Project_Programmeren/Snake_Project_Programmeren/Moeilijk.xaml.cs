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

namespace Snake_Project_Programmeren
{
    /// <summary>
    /// Interaction logic for Moeilijk.xaml
    /// </summary>
    public partial class Moeilijk : Window
    {
        Slang objslang;
        Appel objappel;

        public Moeilijk()
        {
            InitializeComponent();
            objslang = new Slang(cnvcanvas);
            objappel = new Appel(cnvcanvas);
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
