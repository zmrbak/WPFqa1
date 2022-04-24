using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WPFQ013
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //第一种方式：设置成静态变量，确保不会被垃圾回收器释放
        static Mutex mutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            mutex = new Mutex(true, "单实例程序", out bool isNewInstance);

            //第二种方式：直接控制垃圾回收器（不推荐）
            //Mutex mutex = new Mutex(true, "单实例程序", out bool isNewInstance);
            //GC.KeepAlive(mutex);

            if (isNewInstance != true)
            {
                //MessageBox.Show("程序已经启动");
                IntPtr intPtr = FindWindowW(null, "单实例应用程序");
                if (intPtr != IntPtr.Zero)
                {
                    SetForegroundWindow(intPtr);
                }

                Shutdown();
            }
        }
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowW(String lpClassName, String lpWindowName);
        [DllImport("User32", CharSet = CharSet.Unicode)]
        static extern Boolean SetForegroundWindow(IntPtr hWnd);
    }
}
