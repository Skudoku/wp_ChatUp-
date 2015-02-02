using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wp_ChatUp_
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Roomname { get; set; }
        public int Usercount { get; set; }
        public string Language { get; set; }


        public Room(string roomname, string language)
        {
            this.Roomname = roomname;
            this.Language = language;
        }
    }
}
