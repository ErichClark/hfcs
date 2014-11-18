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

namespace UseTheDebugger
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15; //There's a breakpoint in this line.
            int count = 0;
            string result = "hello";
            bool yesNo = false;
            bool anotherBool = true;

            number = number + 10;
            number = 36 * 18;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            
            count++;
            count--;

            result += " again " + result;
            output.Text = result;
            result = "the value is: " + count;
            result = "";

            yesNo = !anotherBool;
        }
    }
}
