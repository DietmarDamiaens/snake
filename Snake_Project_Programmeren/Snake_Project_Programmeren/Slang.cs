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
        Rectangle objrectangle = new Rectangle();
        bool _geraakt;
        const int _pasgrootte = 20;

        //constructor

        public Slang(Canvas pcnvcanvas)
        {
            _canvas = pcnvcanvas;
            _diameter = 10;
            objrectangle.Width = _diameter;
            objrectangle.Height = _diameter;
            _x = Convert.ToInt32(_canvas.Width / 2);
            _y = Convert.ToInt32(_canvas.Height / 2);
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
            objrectangle.Fill = new SolidColorBrush(Colors.Blue);
            objrectangle.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(objrectangle);
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

        public void Naarrechts()
        {
            _x = _x + _pasgrootte;
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarlinks()
        {
            _x = _x - _pasgrootte;
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naaronder()
        {
            _y = _y + _pasgrootte;
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
        }
        public void Naarboven()
        {
            _y = _y - _pasgrootte;
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
        }

    }
}
