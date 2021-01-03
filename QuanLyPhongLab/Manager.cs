﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ConsoleTools;

namespace QuanLyPhongLab
{
    public enum OnOFF
    {
        on,
        off
    }
    public class Manager : Human, INotifyPropertyChanged
    {
        public delegate object delegateDV(params object[] thamso);
        public delegate bool delegateCondition(string pas);
        public delegate object delegateFunction(params object[] pas);
        public event PropertyChangedEventHandler PropertyChanged;

        public Cabinet cabinet { get; set; }
        private OnOFF _statusManager;
        public OnOFF statusManager { get { return this._statusManager; } }
        private Database managerDB;
        private string password = String.Empty;
        public string account { get; }

        public Manager(string name, string age, string id, string password, string account) : base(name, age, id)
        {
            this.account = account;
            this.password = password;
            managerDB = new Database();
        }
        public Manager(Human human, string password, string account) : base(human)
        {
            this.password = password;
            this.account = account;
            managerDB = new Database();
        }
        public Manager(string account, string password)
        {
            managerDB = new Database();
            this.password = password;
            this.account = account;
        }

        //

        protected bool CheckPassword(string pass)
        {
            return this.password == pass;
        }
        protected bool CheckAccount(string account)
        {
            return this.account == account;
        }

        //
        public virtual object ManagerActionChangePassword(delegateFunction func,params object[] pas)
        {
            if (this.statusManager==OnOFF.on)
            {
                return SelectFunction(func, pas); //
            }
            return "sai mat khau hoac tai khoan";
        }
        //
        protected object SelectFunction(delegateFunction func,params object[] pas)
        {
            return func(pas);
        }
        public object ChangePassWord(params object[] pas) {
            this.PropertyChanged += Manager_PropertyChanged;
            string pass = (string)Enter(new delegateCondition(PasswordCondition));
            this.password = pass;
            NotifyPropertyChanged();
            return pass;
        }
        public object InfoDevice(params object[] pas) // pas[0] la device
        {
            managerDB.queryEvent += ManagerDB_querySelect;
            return managerDB.Query(pas[0]);
        }
        public Manager SignUp(params object[] pas)
        {
            string account = (string)Enter(new delegateCondition(AccountCondition));
            string pass = (string)Enter(new delegateCondition(PasswordCondition));
            return new Manager(account, pass);
        }
        public static bool PasswordCondition(string str)
        {
            //kiem tra rang buoc password;
            return true;
        }
        public static bool AccountCondition(string str)
        {
            //kiem tra rang buon cua account;
            return true;
        }
        public static object Enter(delegateCondition check, params object[] pas)
        {
            string str = Console.ReadLine();
            if (check(str)) return str;
            return "";
        }
        public object SignIn(params object[] pas)
        {
            string account = Console.ReadLine();
            string pass = Console.ReadLine();
            if (CheckAccount(account) == true && CheckPassword(pass) == true)
            {
                this._statusManager = OnOFF.on;
                return true;
            }
            return false;
        }
        public object RemoveDevice(Device device) //thanh li
        {
            managerDB.queryEvent += ManagerDB_queryUpdateAdd;
            return managerDB.Query(device);
        }
        public object AddDevice(Device device) //them thiet bi
        {
            managerDB.queryEvent += ManagerDB_queryUpdateRemove;
            return managerDB.Query(device);
        }
        public object openLabRoom(params object[] pas)
        {
            return "\nOpen";
        }
        public object closeLabRoom(params object[] pas)
        {
            return "\nClose";
        }

        public bool kiemTra(params object[] thamso) //kiem tr thiet bi sau moi buoi
        {
            Random rand = new Random();
            return rand.NextDouble() > 0.5;

        }
        public object repairDV(params object[] thamso)
        {

            return "repair device";
        }
        public object processingUS(delegateDV processing, params object[] thamso)  //hinh thuc xu li
        {
            bool kq = kiemTra();
            if (kq)
                return "thiet bi van tot";
            object result1 = repairDV();
            object result2 = levelProcessing(processing, thamso);
            managerDB.queryEvent += ManagerDB_queryEvent1;
            return managerDB.Query();

        }
        public object levelProcessing(delegateDV processing, params object[] thamso)
        {
            return processing(thamso);
        }
        public object payMoney(params object[] thamso)//nộp tiền
        {
            return "pay money";
        }
        public object remind(params object[] thamso)//nhắc nhở
        {
            return "remind";
        }
        public object discipline(params object[] thamso)//kỉ luật
        {
            return "discipline";
        }
        public object addCabinet(params object[] thamso) // thêm đồ vào tủ
        {
            return "add device Cabinet";
        }
        public object authorizationDV(params object[] thamso)//cấp quyền
        {
            return " authorization device";
        }
        public object collectionOfRights(params object[] thamso) //thu quyền
        {
            return "collection of rights";
        }
        public object baoCao(params object[] thamso) // tổng kết báo cáo cuối kì
        {
            return "";
        }

        //
        private object ManagerDB_querySelect(params object[] pas)
        {
            return "truy van select lay thong tin ";
        }
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void Manager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            //
            Console.WriteLine("Thay doi mat khau thanh cong"); 
        }
        private object ManagerDB_queryUpdateRemove(params object[] pas) //
        {
            return "Remove device   " + pas[0].GetType().Name;
        }
        private object ManagerDB_queryUpdateAdd(params object[] pas) //
        {
            return "Add device";
        }
        private object ManagerDB_queryEvent1(params object[] pas)
        {
            return "kiem tra xem da chap xu li chua";
        }
    }
}