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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SelectCBox = (1 << 1) | (1 << 2);

        }


        //整数32位
        //0101-----32位

        public int SelectCBox
        {
            get { return (int)GetValue(SelectCBoxProperty); }
            set
            {
                SetValue(SelectCBoxProperty, value);
                CbConverter.SelectCBox = value;
            }
        }

        // Using a DependencyProperty as the backing store for SelectCBox.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectCBoxProperty =
            DependencyProperty.Register("SelectCBox", typeof(int), typeof(MainWindow), new PropertyMetadata(default(int)));
    }
}
