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
    }
}
