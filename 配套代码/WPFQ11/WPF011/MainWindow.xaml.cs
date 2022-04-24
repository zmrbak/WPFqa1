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

namespace WPF011
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        Uri uriA = new Uri("PageA.Xaml", UriKind.RelativeOrAbsolute);
        Uri uriB = new Uri("PageB.Xaml", UriKind.RelativeOrAbsolute);
        private void Button_ClickA(object sender, RoutedEventArgs e)
        {
            myFrame.Source = uriA;
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            myFrame.Source = uriB;

        }
    }
}
