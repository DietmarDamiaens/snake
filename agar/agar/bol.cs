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
    class bol
    {
        //variabelen

        Canvas _canvas = new Canvas();
        private int _diameter, _x, _y, _richtingsgetal;
        Random objrandom = new Random(Guid.NewGuid().GetHashCode());
        Image imgbol = new Image();
        private string _richting;
        bool _geraakt;
        const int _pasgrootte = 5;
        DispatcherTimer _tmrbewegen = new DispatcherTimer();

        //constructor

        public bol(Canvas pcnvcanvas)
        {
            _canvas = pcnvcanvas;
            _diameter = objrandom.Next(10, 100);
            imgbol.Width = _diameter;
            imgbol.Height = _diameter;
            _x = objrandom.Next(0, Convert.ToInt32(_canvas.Width - _diameter));
            _y = objrandom.Next(0, Convert.ToInt32(_canvas.Height - _diameter));

            imgbol.Source = new BitmapImage(new Uri("/images/Bol.png", UriKind.Relative));
            imgbol.Margin = new Thickness(_x, _y, 0, 0);
            _canvas.Children.Add(imgbol);
        }

        //eigenschappen

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public int Diameter
        {
            get
            {
                return _diameter;
            }

            set
            {
                _diameter = value;
            }
        }

        public bool Geraakt
        {
            get
            {
                return _geraakt;
            }
        }

        //methoden

        public void checkagargeraakt(agario pagar)
        {
            int ax, ay, bx, by;
            ax = pagar.X + (pagar.Diameter / 2);
            ay = pagar.Y + (pagar.Diameter / 2);
            bx = _x + (_diameter / 2);
            by = _y + (_diameter / 2);

            if (Math.Sqrt(Math.Pow((ax - bx),2) + Math.Pow((ay-by),2))<= (_diameter/2 + pagar.Diameter/2))
            {
                imgbol.Source = new BitmapImage(new Uri("/images/BolBlauw.png", UriKind.Relative));
                _geraakt = true;
            }

        }

    }
}
