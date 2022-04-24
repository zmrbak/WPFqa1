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

namespace ImageButton
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

        int index = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index % 2 == 1)
            {
                ExImage.SetImageFile(btn1, new BitmapImage(new Uri("34521.ico", UriKind.RelativeOrAbsolute)));
                //btn1.ImageFile = new BitmapImage(new Uri("34521.ico", UriKind.RelativeOrAbsolute));
            }
            else
            {
                ExImage.SetImageFile(btn1, new BitmapImage(new Uri("3452.png", UriKind.RelativeOrAbsolute)));
                //btn1.ImageFile = new BitmapImage(new Uri("3452.png", UriKind.RelativeOrAbsolute));
            }
        }
    }
}