using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class ServerModel : Device , IinfoComputer
    {
        public DateTime previousMaintenanceDate { get; set; }
        public OperatingSystem nameOfOS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal nameOfRam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int sizeOfDisk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nameOfCPU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ServerModel() { }
        public ServerModel(DateTime predate, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price, OperatingSystem nameofos, decimal nameofram,
            int sizeofdisk, string nameofcpu)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.previousMaintenanceDate = predate;
            this.nameOfOS = nameofos;
            this.nameOfRam = nameofram;
            this.sizeOfDisk = sizeofdisk;
            this.nameOfCPU = nameofcpu;
        }
        public ServerModel(Device device) : base(device)
        {
        }
    }

}
