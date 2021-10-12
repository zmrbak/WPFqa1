using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfQ27
{
    public class MainViewModel : BindableBase
    {
        private string userName="user";

        public string UserName
        {
            get { return userName; }
            set
            {
                SetProperty(ref userName, value);
            }
        }

        private string password="222";

        public string Password
        {
            get { return password; }
            set
            {
                SetProperty(ref password, value);
            }
        }

        public MainViewModel()
        {
            LoginCommand = new DelegateCommand(OnLogin);
        }

        public DelegateCommand LoginCommand { get; }

        private void OnLogin()
        {
            MessageBox.Show("UserName：" + userName + "\nPassword:" + password);
        }
    }
}
