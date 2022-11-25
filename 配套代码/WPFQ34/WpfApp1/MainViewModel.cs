using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    internal class MainViewModel:BindableBase
    {
        public MainViewModel()
        {
            TabControlCommand = new DelegateCommand<SelectionChangedEventArgs>(DoTabControlCommand);
            ComboxCommand = new DelegateCommand<SelectionChangedEventArgs>(DoComboxCommand);
        }

        private void DoComboxCommand(SelectionChangedEventArgs e)
        {
            MessageBox.Show("DoComboxCommand");
            e.Handled = true;
        }

        //private void DoComboxCommand(object obj)
        //{
        //    var e = obj as SelectionChangedEventArgs;
        //    MessageBox.Show("DoComboxCommand");
        //    e.Handled = true;
        //}

        private void DoTabControlCommand(object obj)
        {
            MessageBox.Show("DoTabControlCommand");
        }

        public DelegateCommand<SelectionChangedEventArgs> TabControlCommand { get; }
        public DelegateCommand<SelectionChangedEventArgs> ComboxCommand { get; }
    }
}
