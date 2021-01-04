using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public abstract class Room
    {
        public StatusRoom statusOfRoom { get; set; }
        public string idOfRoom { get; set; }
        public string posOfRoom { get; set; }
        public Room() { }
        public Room(string id, string pos, StatusRoom status)
        {
            this.idOfRoom = id;
            this.posOfRoom = pos;
            this.statusOfRoom = status;
        }
        
    }
}
