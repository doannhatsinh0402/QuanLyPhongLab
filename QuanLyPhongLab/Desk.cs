using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Desk : Device
    {
        //public string posOfDesk { get; set; } 
        public Type typeDesk { get; set; }
        public Desk() { }
        public Desk(Type typedesk, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.typeDesk = typedesk;
        }
        public Desk(Device device) : base(device)
        { }
    }

}
