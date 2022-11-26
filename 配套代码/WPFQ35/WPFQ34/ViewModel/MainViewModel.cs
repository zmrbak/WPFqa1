using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFQ34.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            TabControlCommand = new RelayCommand<object>(DoTabControlCommand);
            ComboxCommand = new RelayCommand<object>(DoComboxCommand);
        }

        private void DoComboxCommand(object obj)
        {
            var e = obj as SelectionChangedEventArgs;
            MessageBox.Show("DoComboxCommand");
            e.Handled = true;
        }

        private void DoTabControlCommand(object obj)
        {
            MessageBox.Show("DoTabControlCommand");
        }

        public RelayCommand<object> TabControlCommand { get; }
        public RelayCommand<object> ComboxCommand { get; }


    }
}