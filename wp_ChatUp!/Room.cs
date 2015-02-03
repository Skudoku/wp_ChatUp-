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

        public int GetRoomID(Room room)
        {
            return room.RoomID;
        }

        public List<Room> GetRooms(string language)
        {
            List<Room> roomsList = new List<Room>();

            return roomsList;
        }
    }
}
