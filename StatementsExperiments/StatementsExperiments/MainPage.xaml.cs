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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StatementsExperiments
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string name = "Erich";
            int x = 3;
            double d = 0;

            x = x * 17;
            d = Math.PI / 2;
            myLabel.Text = "name is " + name
                + "\nx is " + x
                + "\nd is " + d;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 10;

            if (x == 10)
            {
                myLabel.Text = "x must be 10";
            }
            else
            {
                myLabel.Text = "x isn't 10";
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr.";

            if((someValue == 3) && (name == "Joe"))
            {
                myLabel.Text = "x is 3 and the name is Joe";
            }

            myLabel.Text = "this line runs no matter what";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int p = 2;
            int loopCount = 0;

            for (int q = 2; q < 32; q = q *2 )
            {
                while (p < q)
                {
                    p = p * 2;
                }

                q = p - q;
                loopCount++;
            }

            myLabel.Text = "The number of loops was " + loopCount;
        }
    }
}
