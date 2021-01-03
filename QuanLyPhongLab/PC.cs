using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class PC : Device, IinfoComputer
    {
        public OperatingSystem nameOfOS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal nameOfRam { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int sizeOfDisk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string nameOfCPU { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PC() { }
        public PC(OperatingSystem nameofos, Decimal nameofram, int sizeofdisk, string nameofcpu,
            Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty,price)
        {
            this.nameOfOS = nameofos;
            this.nameOfRam = nameofram;
            this.sizeOfDisk = sizeofdisk;
            this.nameOfCPU = nameofcpu;
        }
        public PC(Device device) : base(device)
        {
        }
    }

}
