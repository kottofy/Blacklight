using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Blacklight
{
    public class Messaging
    {
        public static async void InsertMessage(InspirationMessage message)
        {
            await App.MobileService.GetTable<InspirationMessage>().InsertAsync(message);
        }

        public static async void InsertChatMessage(ChatMessage message)
        {
            await App.MobileService.GetTable<ChatMessage>().InsertAsync(message);
        }

        
    }
}
