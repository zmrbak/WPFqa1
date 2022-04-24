using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFQ014
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //获取当前窗口句柄
            IntPtr handle = new WindowInteropHelper(this).Handle;

            //启动notepad.exe
            Process app = Process.Start("notepad.exe");

            //主窗口句柄
            IntPtr prsmwh = app.MainWindowHandle;

            while (prsmwh == IntPtr.Zero)
            {
                prsmwh = app.MainWindowHandle;
            }

            //设置父窗口
            SetParent(prsmwh, handle);

            //子窗口最大化 
            ShowWindowAsync(prsmwh, 3);

        }

        //声明调用user32.dll中的函数
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll")]
        static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
    }
}
