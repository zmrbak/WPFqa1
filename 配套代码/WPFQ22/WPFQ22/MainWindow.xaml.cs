using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace WPFQ22
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WxHttpServer wxHttpServer = new WxHttpServer();
            wxHttpServer.Port = 8421;
            wxHttpServer.OnDataReceived += WxHttpServer_OnDataReceived;
            wxHttpServer.Start();
        }

        private void WxHttpServer_OnDataReceived(System.Net.HttpListenerRequest reqeust, System.Net.HttpListenerResponse response)
        {
            Console.WriteLine(reqeust.Url);

            string responseString = "";
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;
            output.Write(buffer, 0, buffer.Length);
            output.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            List<SamplaData> samplaDatas = new List<SamplaData>();

            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                SamplaData samplaData = new SamplaData();
                samplaData.Index = i;
                samplaData.Name = i + "My Name";
                samplaData.ImagePath = "http://127.0.0.1:8421/" + i + ".jpg";
                samplaDatas.Add(samplaData);


                //ListBoxItem listBoxItem = new ListBoxItem();
                //StackPanel stackPanel = new StackPanel();
                //TextBlock textBlock1 = new TextBlock();
                //TextBlock textBlock2 = new TextBlock();
                //TextBlock textBlock3 = new TextBlock();
                //textBlock1.Text = samplaData.Index.ToString();
                //textBlock2.Text = samplaData.Name;
                //textBlock3.Text = samplaData.ImagePath;

                //stackPanel.Children.Add(textBlock1);
                //stackPanel.Children.Add(textBlock2);
                //stackPanel.Children.Add(textBlock3);

                //listBoxItem.Content = stackPanel;

                //listBox.Items.Add(listBoxItem);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);

            this.listBox.ItemsSource = samplaDatas;
        }
    }

    public class SamplaData
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
