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

namespace agar
{
    class agario
    {
        //variabelen
        Canvas _canvas = new Canvas();
        Image imgSmiley = new Image();
        int _diameter, _x, _y;

        const int _pasgrootte = 5;

        //constructor
        public agario(Canvas pcnvCanvas)
        {
            _canvas = pcnvCanvas;
            _diameter = 50;
            imgSmiley.Height = _diameter;
            imgSmiley.Width = _diameter;
            _x = Convert.ToInt32(_canvas.Width / 2);
            _y = Convert.ToInt32(_canvas.Height / 2);
            imgSmiley.Margin = new Thickness(_x, _y, 0, 0);
            imgSmiley.Source = new BitmapImage(new Uri("/Images/AgarSmile.png", UriKind.Relative));
            _canvas.Children.Add(imgSmiley);
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

        //methoden

        public void Naarrechts()
        {
            _x = _x + _pasgrootte;
            imgSmiley.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarlinks()
        {
            _x = _x - _pasgrootte;
            imgSmiley.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naaronder()
        {
            _y = _y + _pasgrootte;
            imgSmiley.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarboven()
        {
            _y = _y - _pasgrootte;
            imgSmiley.Margin = new Thickness(_x, _y, 0, 0);
        }






    }
}
