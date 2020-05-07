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

namespace WPFQ20
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            grid.Width = 50;
            grid.Height = 50;
            grid.Background = Brushes.AliceBlue;

            //textBlock.Text = grid;
            //textBlock.Inlines = grid;
            //textBlock.con
            //textBlock.c

            textBlock.Inlines.Add(grid);
            //InlineUIContainer inlineUI = new InlineUIContainer();
            //inlineUI.Child = grid;

            //textBlock.Inlines.Add(inlineUI);

        }
    }
}
