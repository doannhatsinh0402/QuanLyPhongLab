using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Chair : Device
    {
        public Type typeChair { get; set; }

        public Chair() { }
        public Chair(Type typechair, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.typeChair = typechair;
        }
        public Chair(Device device) : base(device) { }
    }

}
