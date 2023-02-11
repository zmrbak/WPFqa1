using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpfq36
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textBlockA = "222";

        [ObservableProperty]
        private string textBlockB = "111";

        [ObservableProperty]
        private string textBlockC = "222";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TextBlockC))]
        private bool isCheckBoxChecked;

        partial void OnIsCheckBoxCheckedChanged(bool value)
        {
            TextBlockC = value ? TextBlockB : TextBlockA;
        }

        [RelayCommand]
        private void CBChanged(bool arg)
        {
            TextBlockC = arg ? TextBlockB : TextBlockA;
        }
    }
}
