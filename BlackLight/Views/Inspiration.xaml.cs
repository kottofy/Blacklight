using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Blacklight.Views
{
    public sealed partial class Inspiration : Page
    {
        public Inspiration()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        public void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), "");
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Profile), "");
        }

        private void CouponButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Coupons), "");
        }

        private void InspirationButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Inspiration), "");
        }


        private async void Retrive_Click(object sender, RoutedEventArgs e)
        {
            List<InspirationMessage> allMessages = await App.MobileService.GetTable<InspirationMessage>().ToListAsync();

            string res = "";

            foreach (InspirationMessage mess in allMessages)
            {
                res += "Message :" + mess.content + "\n\n";
            }

            var m1 = new MessageDialog(res).ShowAsync();

        }
    }
}
