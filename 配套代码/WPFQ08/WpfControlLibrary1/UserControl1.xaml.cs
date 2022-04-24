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

namespace WpfControlLibrary1
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            IsButtonEnabled = bt_Test.IsEnabled;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bt_Test.IsEnabled = !bt_Test.IsEnabled;
            //IsButtonEnabled = bt_Test.IsEnabled;
        }


        public Boolean IsButtonEnabled
        {
            get { return (Boolean)GetValue(IsButtonEnabledProperty); }
            set { SetValue(IsButtonEnabledProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsButtonEnabled.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsButtonEnabledProperty =
            DependencyProperty.Register("IsButtonEnabled", typeof(Boolean), typeof(UserControl1), new PropertyMetadata(null));

        private void Bt_Test_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            IsButtonEnabled = bt_Test.IsEnabled;
        }
    }
}
