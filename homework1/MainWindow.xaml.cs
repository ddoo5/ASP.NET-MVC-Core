using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Thread a = new(() => Fibbonachi());

            a.Start();
        }


        public void Fibbonachi()
        {
            int a = 1;
            int b = 1;
            int res = 0;
            for (int i = 1; i < 45; i++)
            {
                res = a + b;

                a = b;
                b = res;

                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
                {
                    TextBox1.Text += $"{i}: {res}\n";
                }));

                Thread.Sleep(200);
            }
        }

    }
}
