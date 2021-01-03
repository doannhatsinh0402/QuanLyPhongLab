using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Cabinet : Device
    {
        public string posOfCabinet { get; set; }
        public List<Device> listDevices { get; set; }
        protected Database cabinetDB;
        public Cabinet(string pos, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
           string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
           : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.posOfCabinet = pos;
        }
        public Cabinet(Device cabinet):base(cabinet)
        {
        }
        public Cabinet(Device cabinet, List<Device> listdevice) : base(cabinet)
        {
            foreach(var device in listdevice)
                this.listDevices.Add(device); 
        }
        public Cabinet()
        {
            Database cabinetDB = new Database();
        }
    }
}
