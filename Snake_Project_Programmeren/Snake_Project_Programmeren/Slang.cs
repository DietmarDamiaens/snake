using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Snake_Project_Programmeren
{
    class Slang
    {
        //variabelen

        Canvas _canvas = new Canvas();
        private int _diameter, _x, _y;
        Rectangle slang = new Rectangle();
        const int _pasgrootte = 20;

        //constructor

        public Slang(Canvas pcnvcanvas)
        {
            _canvas = pcnvcanvas;
            _diameter = 10;
            slang.Width = _diameter;
            slang.Height = _diameter;
            _x = Convert.ToInt32(_canvas.Width / 2);
            _y = Convert.ToInt32(_canvas.Height / 2);
            slang.Margin = new Thickness(_x, _y, 0, 0);
            slang.Fill = new SolidColorBrush(Colors.Blue);
            slang.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(slang);
        }

        //eigenschappen

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
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
            slang.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarlinks()
        {
            _x = _x - _pasgrootte;
            slang.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naaronder()
        {
            _y = _y + _pasgrootte;
            slang.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarboven()
        {
            _y = _y - _pasgrootte;
            slang.Margin = new Thickness(_x, _y, 0, 0);
        }

    }
}
