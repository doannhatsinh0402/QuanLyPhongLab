using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Keyboard : Device
    {
        public TypeKeyBoard typeOfKB { get; set; }
        public int numOfBadButton { get; set; }
        public Keyboard() { }
        public Keyboard(TypeKeyBoard typeofkb, int numofbadbutton, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.typeOfKB = typeofkb;
        }
        public Keyboard(Device device) : base(device)
        { }
    }

}
