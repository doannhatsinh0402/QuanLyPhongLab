using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public abstract class Device //astract
    {
        public Status qualityStatus { get; set; }
        public DateTime dateOfInstall { get; set; }
        public string nameDevice { get; set; }
        public string nameOfProducer { get; set; }
        public string colorOfDevice { get; set; }
        public string idDevice { get; set; }
        public DateTime dateOfWarranty { set; get; } //thoi gian bao hanh

        public string priceOfDevice { get; set; }
        public Device() { }
        public Device(Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
        {
            this.priceOfDevice = price;
            this.qualityStatus = quality;
            this.dateOfInstall = dateofinstall;
            this.nameDevice = namedevice;
            this.nameOfProducer = nameofproducer;
            this.colorOfDevice = colorofdevice;
            this.idDevice = iddevice;
            this.dateOfInstall = dateofinstall;
        }
        public Device(Device device)
        {
            this.qualityStatus = device.qualityStatus;
            this.dateOfInstall = device.dateOfInstall;
            this.nameDevice = device.nameDevice;
            this.nameOfProducer = device.nameOfProducer;
            this.colorOfDevice = device.colorOfDevice;
            this.idDevice = device.idDevice;
            this.dateOfInstall = device.dateOfInstall;
        }
        public virtual object liquidityDV(params object[] thamso)
        {

            return "tien thanh li \n";
        }

        public virtual object repairDV(params object[] thamso)
        {
            string dateKT = "ngay kiem tra";
            eventDV?.Invoke(dateKT);
            return dateKT;
        }

        public virtual object warrantyDV(params object[] thamso)
        {
            return " bao hanh \n";
        }
        public virtual string report(params object[] thamso)
        {
            string warranty = (string)this.warrantyDV();
            string repair = (string)this.repairDV();
           // string BuyNewDevice = (string)this.buyNewDV(repair);
            string ThanhLi = (string)this.liquidityDV(repair);
            //   string ketqua = warranty + repair + BuyNewDevice + ThanhLi;
            return "bao cao";
        }
        public delegate void delegateDV(string kq);
        public event delegateDV eventDV;
    }

}
