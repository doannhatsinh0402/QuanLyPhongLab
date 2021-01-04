using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongLab
{
    public class Camera : Device
    {
        public Camera() { }
        public Camera(string posofcam)
        {
            this.posOfCamera = posofcam;
        }
        public Camera(string posofcam, Status quality, DateTime dateofinstall, string namedevice, string nameofproducer,
            string colorofdevice, string iddevice, DateTime dateofwarrnty, string price)
            : base(quality, dateofinstall, namedevice, nameofproducer, colorofdevice, iddevice, dateofwarrnty, price)
        {
            this.posOfCamera = posofcam;
        }
        public Camera(Device device) : base(device)
        { }
        public string posOfCamera { get; set; }
        public bool kiemTra(params object[] thamso)
        {
            Database ktDB = new Database();
            ktDB.queryEvent += KtDB_queryEvent;
            return (bool)ktDB.Query();
        }
        private object KtDB_queryEvent(params object[] pas)
        {
            Random rand = new Random();
            return false;
        }
        public object openStream(params object[] thamso)
        {
            return "mo stream de ket noi";
        }
        public object updateDB(params object[] thamso)
        {
            Database kt = new Database();
            kt.queryEvent += Kt_queryEvent;
            return kt.Query(thamso[0]);

        }

        private object Kt_queryEvent(params object[] pas)
        {
            return "update Database" + pas[0];
        }
        public object nhanDang(params object[] thamso)
        {
            Database camera = new Database();
            camera.queryEvent += Camera_queryEvent;
            return camera.Query();
        }

        private object Camera_queryEvent(params object[] pas)
        {
            return "nhan dang";
        }
        public object hoatDong(params object[] thamso)
        {
            bool kt = this.kiemTra(thamso[0]);
            if (kt == true)
                return "camera hoat dong";
            object result = this.openStream();
            object kqb4 = this.updateDB(thamso[0]);
            this.nhanDang();
            return kqb4;

        }
        public object xoayCamera(delegateCamera camera, params object[] thamso)
        {
            object kq = hoatDong(thamso);
            object kq1 = xoayCR(camera, thamso);
            return kq1;
        }
        public object xoayCR(delegateCamera camera, params object[] thamso)
        {
            return camera(thamso);
        }
        public object xoayTrai(params object[] thamso)
        {
            return "xoay trai " + thamso[0] + " do";
        }
        public object xoayPhai(params object[] thamso)
        {
            return "xoay phai " + thamso[0] + " do";
        }
        public delegate object delegateCamera(params object[] thamso);
    }
}
