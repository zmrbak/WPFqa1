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
    /// PageB.xaml 的交互逻辑
    /// </summary>
    public partial class PageB : Page
    {
        public PageB()
        {
            InitializeComponent();
            tbB.Text = Application.Current.Properties["DataB"] == null ? "" : Application.Current.Properties["DataB"].ToString();

        }

        private void TbB_KeyUp(object sender, KeyEventArgs e)
        {
            Application.Current.Properties["DataB"] = tbB.Text;
        }
    }
}
