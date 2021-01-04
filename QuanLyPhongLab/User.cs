using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongLab
{

    public class User : Human
    {
        private Database userDB;
        public User() { userDB = new Database();  }
        public User(string name, string age, string id) : base(name, age, id) {
            userDB = new Database();
        }
        public User(Human human) : base(human) {
            userDB = new Database();
        }
        public object deviceBroke(params object[] thamso)
        {
            userDB.queryEvent += userDB_queryEvent;
            return userDB.Query();
        }
        private object userDB_queryEvent(params object[] pas)
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
