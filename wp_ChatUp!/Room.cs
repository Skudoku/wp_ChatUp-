using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public int LanguageID { get; set; }


        public Room(string roomname, string language)
        {
            this.Roomname = roomname;
            this.Language = language;
        }

        public void JoinRoom(int roomID)
        {
            this.RoomID = roomID;
        }

        public int GetRoomID(string roomname)
        {
            int roomID = 0;
            return roomID;
        }

        public static List<string> GetRooms()
        {
            List<Room> roomsList = new List<Room>();
            List<string> roomnameList = new List<string>();
            Room room1 = new Room("room 1", "Dutch");
            Room room2 = new Room("room 2", "Dutch");
            Room room3 = new Room("room 3", "English");
            roomsList.Add(room1);
            roomsList.Add(room2);
            roomsList.Add(room3);
            roomnameList.Add(room1.Roomname);
            roomnameList.Add(room2.Roomname);
            roomnameList.Add(room3.Roomname);
            return roomnameList;
        }

        public static void AddRoom(string roomname)
        {
            HttpWebRequest roomText = (HttpWebRequest)HttpWebRequest.Create(new Uri("http://www.chatup.nl:800/test/addroom.php?name=" + roomname));
            roomText.BeginGetResponse(Message.ShowText, roomText);
        }
    }
}
