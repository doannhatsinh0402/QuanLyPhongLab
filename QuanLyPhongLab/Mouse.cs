using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Mouse : Device
    {
        public TypeMouse typeOfMouse { get; set; }
        public Mouse() { }
        public Mouse(TypeMouse typeofmouse, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.typeOfMouse = typeofmouse;
        }
        public Mouse(Device device) : base(device)
        { }
    }

}
