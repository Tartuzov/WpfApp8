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

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            int a =r.Next(0,4);
            if (a == 0) {
                sp.Orientation = Orientation.Vertical; 
                sp.VerticalAlignment = VerticalAlignment.Top;
            }
            else if (a == 1)
            {
                sp.Orientation = Orientation.Vertical;
                sp.VerticalAlignment = VerticalAlignment.Bottom;
            }
            else if (a == 2)
            {
                sp.Orientation = Orientation.Horizontal;
                sp.HorizontalAlignment = HorizontalAlignment.Right;
            }
            else if(a == 3)
            {
                sp.Orientation = Orientation.Horizontal;
                sp.HorizontalAlignment = HorizontalAlignment.Left;
            }
        }
    }
}
