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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF03
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
            //String xamlString = XamlWriter.Save(sp2);
            //Object element = XamlReader.Parse(xamlString);
            //UIElement uIElement = (UIElement)element;
            //sp1.Children.Add(uIElement);


            sp1.Children.Add((UIElement)XamlReader.Parse(XamlWriter.Save(sp2)));
        }
    }
}
