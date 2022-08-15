using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfCustomControlLibrary1
{
    public class ClassAttach
    {
        public static int GetTest(DependencyObject obj)
        {
            return (int)obj.GetValue(TestProperty);
        }

        public static void SetTest(DependencyObject obj, int value)
        {
            obj.SetValue(TestProperty, value);
        }

        // Using a DependencyProperty as the backing store for Test.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestProperty =
            DependencyProperty.RegisterAttached("Test", typeof(int), typeof(ClassAttach), new PropertyMetadata(0));


    }
}
