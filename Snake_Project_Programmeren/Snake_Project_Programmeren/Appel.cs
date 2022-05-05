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
    class Appel
    {
        //declaratie

        bool appelaanwezig = false;
        int intmaphoogte, intmapbreedte, _xappel, _yappel, intappeldiameter;
        Canvas _canvas = new Canvas();
        Ellipse objappel = new Ellipse();
        Random objrandom = new Random();
        DispatcherTimer _tmrcontrole = new DispatcherTimer();

        //conctructor
        public Appel(Canvas pcanvas)
        {
            _canvas = pcanvas;

            intmaphoogte = Convert.ToInt32(_canvas.Height);
            intmapbreedte = Convert.ToInt32(_canvas.Width);

            _xappel = objrandom.Next(intmapbreedte - intappeldiameter);
            _yappel = objrandom.Next(intmapbreedte - intappeldiameter);

            objappel.Margin = new Thickness(_xappel, _yappel, 0, 0);
            objappel.Fill = new SolidColorBrush(Colors.Red);
            objappel.Height = intappeldiameter;
            objappel.Width = intappeldiameter;
            objappel.Stroke = new SolidColorBrush(Colors.Black);
            _canvas.Children.Add(objappel);
            appelaanwezig = true;

        }

        //eigenschappen

        public int X
        {
            get
            {
                return _xappel;
            }
        }

        public int Y
        {
            get
            {
                return _yappel;
            }
        }

        //methoden
    }
}
