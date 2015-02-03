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
        public string MessageText { get; private set; }
        public int MessageID { get; set; }
        public int RoomID { get; set; }

        public Room Room { get; set; }

        public Message()
        {

        }

        public Message(string messagetext, string username, int roomid)
        {
            this.MessageText = messagetext;
            this.Username = username;
            this.RoomID = roomid;
        }

        public void Send(string username, string messagetext)
        {
            this.Username = username;
            this.MessageText = messagetext;
            
            //this.Room = room;
            WebView wv = new WebView();
            wv.Navigate(new Uri("http://chatup.nl:800/test/message.php?message=" + WebUtility.UrlEncode(messagetext) + "&uname=" + WebUtility.UrlEncode(username)));            
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

        public static string GetMessage(int MessageID)
        {
            Message messageByID;
            HttpWebRequest messageText = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getmessage.php?id=" + Convert.ToString(MessageID)));
            messageText.BeginGetResponse(ShowText, messageText);
            HttpWebRequest userName = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getusername.php?id=" + Convert.ToString(MessageID)));
            userName.BeginGetResponse(ShowText, userName);
            HttpWebRequest roomID = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/getroomid.php?id=" + Convert.ToString(MessageID)));
            roomID.BeginGetResponse(ShowText, roomID);

            string messagetext = Convert.ToString(messageText);
            string username = Convert.ToString(userName);
            //int roomid = Convert.ToInt32(roomID);
            //messageByID = new Message(messagetext, username, roomid);
            //return messageByID;
            return messagetext;
            
        }

        public static void ShowText(IAsyncResult result)
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
