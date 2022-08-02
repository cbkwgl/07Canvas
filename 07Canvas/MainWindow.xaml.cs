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

namespace _07Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Boolean draw = false;
        public static double x = 0, y=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cnv_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            draw = !draw;
            x = e.GetPosition(cnv).X;
            y = e.GetPosition(cnv).Y;
        }

        private void cnv_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Line ln = new Line();
                ln.X1 = x;
                ln.Y1 = y;
                ln.X2 = e.GetPosition(cnv).X;
                ln.Y2 = e.GetPosition(cnv).Y;
                ln.StrokeThickness = 3;
                ln.Stroke = Brushes.Fuchsia;
                cnv.Children.Add(ln);
            }
        }
    }
}
