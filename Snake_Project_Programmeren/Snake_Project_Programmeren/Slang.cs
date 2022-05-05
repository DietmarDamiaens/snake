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
        private int _diameter, _x, _y, _richtingsgetal;
        Random objrandom = new Random(Guid.NewGuid().GetHashCode());
        Rectangle objrectangle = new Rectangle();
        private string _richting;
        bool _geraakt;
        const int _pasgrootte = 5;
        DispatcherTimer _tmrbewegen = new DispatcherTimer();

        //constructor

        public Slang(Canvas pcnvcanvas)
        {
            _canvas = pcnvcanvas;
            _diameter = 10;
            objrectangle.Width = _diameter;
            objrectangle.Height = _diameter;
            _x = objrandom.Next(0, Convert.ToInt32(_canvas.Width - _diameter));
            _y = objrandom.Next(0, Convert.ToInt32(_canvas.Height - _diameter));
            objrectangle.Margin = new Thickness(_x, _y, 0, 0);
            objrectangle.Fill = new SolidColorBrush(Colors.Black);
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

    }
}
