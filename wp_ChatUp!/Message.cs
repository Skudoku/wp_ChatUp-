using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using System.Net;
using Windows.UI.Xaml.Controls;


namespace wp_ChatUp_
{
    public class Message
    {
 
        public string Username { get; private set; }
        public string MessageToSend { get; private set; }

        public Room Room { get; set; }

        public Message()
        {

        }

        public void Send(string username, string messagetosend)
        {
            this.Username = username;
            this.MessageToSend = messagetosend;
            
            //this.Room = room;

            WebView wv = new WebView();
            wv.Navigate(new Uri("http://chatup.nl/test/message.php?message=" + WebUtility.UrlEncode(messagetosend) + "&uname=" + WebUtility.UrlEncode(username)));
        }
    }
}
