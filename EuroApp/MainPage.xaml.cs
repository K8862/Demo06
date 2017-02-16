using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EuroApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public double Markka = 0;
        public double Euro = 0;
        private void euroButton_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(euroBox.Text);
            Markka = value * 5.94573;
            markkaBox.Text = Markka.ToString("0.00");
        }

        private void markkaButton_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(markkaBox.Text);
            Euro = value / 5.94573;
            euroBox.Text = Euro.ToString("0.00");
        }

    }
}
