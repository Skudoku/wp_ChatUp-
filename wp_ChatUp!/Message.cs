using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using System.Net;
using Windows.UI.Xaml.Controls;
using System.IO;
using System.Diagnostics;

namespace wp_ChatUp_
{
    public class Message
    {

        public string Username { get; private set; }
        public string MessageToSend { get; private set; }
        public int MessageID { get; set; }

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
            try
            {
                wv.Navigate(new Uri("http://chatup.nl:800/test/message.php?message=" + WebUtility.UrlEncode(messagetosend) + "&uname=" + WebUtility.UrlEncode(username)));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            
        }

        public List<Message> GetMessages()
        {
            List<Message> messageList = new List<Message>();

            return messageList;
        }

        //public Message GetMessage(int messageID)
        //{
        //    this.MessageID = messageID;
        //
        //    WebView wv = new WebView();
        //    wv.Navigate(new Uri("http://chatup.nl/test/getmessage.php?id=" + messageID));
        //    Message newMessage = null;
        //    return newMessage;
        //}

        public static void GetMessage(int MessageID)
        {
            HttpWebRequest messageText = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getmessage.php?id=" + Convert.ToString(MessageID)));
            messageText.BeginGetResponse(ShowText, messageText);
            HttpWebRequest userName = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getusername.php?id=" + Convert.ToString(MessageID)));
            userName.BeginGetResponse(ShowText, userName);
            HttpWebRequest roomName = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getroomname.php?id=" + Convert.ToString(MessageID)));
            roomName.BeginGetResponse(ShowText, roomName);

            string messagetext = Convert.ToString(messageText);

        }

        private static void ShowText(IAsyncResult result)
        {
            HttpWebRequest request = (HttpWebRequest)result.AsyncState;
            HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result);

            using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
            {
                string content = streamReader.ReadToEnd();
                Debug.WriteLine(content);
            }
        }
    }
}
