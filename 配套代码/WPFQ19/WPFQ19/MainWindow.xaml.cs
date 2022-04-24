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

namespace WPFQ19
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton== MouseButtonState.Pressed)
            {               
                menu.IsHitTestVisible = false;
                //menu.IsEnabled = false;
                this.DragMove();
            }
            else
            {               
                menu.IsHitTestVisible = true;
                //menu.IsEnabled = true;
            }
        }
    }
}
