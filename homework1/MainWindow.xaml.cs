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
        }

        private int Fibonachi(int value)
        {
            if (value is 0 or 1) return value;

            return Fibonachi(value - 1) + Fibonachi(value - 2);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ButtonStart.IsEnabled = false;

            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 45; i++)
                {
                    int sleep = 0;
                    var result = Fibonachi(i);

                    Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
                    {
                        sleep = (int)Slider.Value;
                        TextBox1.Text += $"{result}\n";
                    }));

                    if (sleep != 0)
                        Thread.Sleep(sleep);
                }

                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
                {
                    ButtonStart.IsEnabled = true;
                }));
            });

            thread.IsBackground = true;

            thread.Start();
        }

        private void Slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Console.WriteLine(Slider.Value);
        }

    }
}
