using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF016
{
    public class HMIInputBox:TextBox
    {
        public Boolean Alarm
        {
            get { return (Boolean)GetValue(AlarmProperty); }
            set { SetValue(AlarmProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Alarm.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AlarmProperty =
            DependencyProperty.Register("Alarm", typeof(Boolean), typeof(HMIInputBox), new PropertyMetadata(OnValueChanged));

    
        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HMIInputBox control = d as HMIInputBox;
            if(control !=null)
            {
                control.UpdtateState();
            }
        }

        private void UpdtateState()
        {
           if(Alarm == true)
            {
                VisualStateManager.GoToState(this, "AlarmState", true);
            }
            else
            {
                VisualStateManager.GoToState(this, "WarnState", true);
            }
        }
    }
}
