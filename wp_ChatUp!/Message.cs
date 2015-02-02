using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Send(string username, string messagetosend, Room room)
        {
            this.Username = username;
            this.MessageToSend = messagetosend;
            this.Room = room;
        }
    }
}
