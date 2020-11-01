using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace MelfColorTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void control1_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void control1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Debug.Print(this.control1.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0)).ToString());
        }
    }
}
