using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongLab
{

    public class User : Human
    {
        private Database managerDB;
        public User() { }
        public User(string name, string age, string id) : base(name, age, id) { }
        public User(Human human) : base(human) { }
        public object deviceBroke(params object[] thamso)
        {
            managerDB.queryEvent += ManagerDB_queryEvent;
            return managerDB.Query();
        }
        private object ManagerDB_queryEvent(params object[] pas)
        {
            return "ten thiet bi hu";
        }
        public object compensationDV(params object[] thamso)
        {
            object kq = deviceBroke();
            return "den bu theo quy dinh";
        }
        public object receiveOfRights(params object[] thamso) // nhận quyền
        {
            return " receive of rights ";

        }
    }
}
