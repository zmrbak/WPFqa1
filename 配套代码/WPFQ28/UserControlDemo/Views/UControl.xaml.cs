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
using UserControlDemo.Models;
using UserControlDemo.ViewModels;

namespace UserControlDemo.Views
{
    /// <summary>
    /// UControl.xaml 的交互逻辑
    /// </summary>
    public partial class UControl : UserControl
    {
        private UControlViewModel ViewModel = null;
        public UControl()
        {
            InitializeComponent();
            ViewModel = Resources["ViewModel"] as UControlViewModel;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //var userInfo = ViewModel.UserInfo;
            //userInfo.FirstName = "111";
            //userInfo.LastName = "222";
            //ViewModel.UserInfo = userInfo;

            UserInfoModel userInfoModel=new UserInfoModel();
            userInfoModel.FirstName =  "111";
            userInfoModel.LastName = "222";
            ViewModel.UserInfo = userInfoModel;

        }
    }
}
