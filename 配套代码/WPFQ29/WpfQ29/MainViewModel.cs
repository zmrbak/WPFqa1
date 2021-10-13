using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfQ29
{
    internal class MainViewModel : BindableBase
    {
        private string password="111";

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public MainViewModel()
        {
            LoginCommand = new DelegateCommand(OnLogin);
        }

        private void OnLogin()
        {
            MessageBox.Show(password);
        }

        public DelegateCommand LoginCommand { get; set; }

    }
}
