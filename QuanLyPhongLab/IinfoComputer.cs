using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public interface IinfoComputer
    {
        public OperatingSystem nameOfOS { get; set; }
        public Decimal nameOfRam { get; set; }
        public int sizeOfDisk { get; set; }
        public string nameOfCPU { get; set; }
    }
}
