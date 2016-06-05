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
        public static async void InsertMessage(Message message)
        {
            await App.MobileService.GetTable<Message>().InsertAsync(message);
        }

        //TODO: Fix this returning Task thing
        public static async Task<List<Message>> RetrieveMessage()
        {
            List<Message> allMessages = await App.MobileService.GetTable<Message>().ToListAsync();
            return allMessages;
        }

        public static async void InsertChatMessage(ChatMessage message)
        {
            await App.MobileService.GetTable<ChatMessage>().InsertAsync(message);
        }
    }
}
