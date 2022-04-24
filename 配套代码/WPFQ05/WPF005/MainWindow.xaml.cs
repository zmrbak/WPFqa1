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
using System.Windows.Markup;

namespace WPF005
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
            String xamlString = XamlWriter.Save(sp2);
            Object element = XamlReader.Parse(xamlString);
            UIElement uIElement = (UIElement)element;

            ((TextBox)(((StackPanel)uIElement).Children[1])).Text += " " + index;
            ((Button)(((StackPanel)uIElement).Children[2])).Click += Button_Click_1;
            sp1.Children.Add(uIElement);


            //sp1.Children.Add((UIElement)XamlReader.Parse(XamlWriter.Save(sp2)));
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null) return;

            //StackPanel
            DependencyObject sp2 = VisualTreeHelper.GetParent(button);
            DependencyObject sp1 = VisualTreeHelper.GetParent(sp2);

            ((StackPanel)sp1).Children.Remove((StackPanel)sp2);


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String textString = "";
            //sp1.Children
            foreach (var item in sp1.Children)
            {
                if (item is StackPanel stackPanel)
                {
                    TextBox textBox = stackPanel.Children[1] as TextBox;
                    if (textBox == null) continue;
                    textString += textBox.Text + Environment.NewLine;
                }
            }
            MessageBox.Show(textString);
        }
    }
}
