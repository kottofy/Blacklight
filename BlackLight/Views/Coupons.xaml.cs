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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Blacklight.Views
{
    public sealed partial class Coupons : Page
    {
        public Coupons()
        {
            this.InitializeComponent();
        }


        public void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        public void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), "");
        }

        public void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Profile), "");
        }

        public void CouponButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Coupons), "");
        }

        public void InspirationButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Inspiration), "");
        }
    }
}
