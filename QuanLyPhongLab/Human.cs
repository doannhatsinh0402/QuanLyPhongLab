using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public abstract class Human
    {
        public string fullName { get; set; }
        public string valueOfAge { get; set; }
        public string valueOfId { get; set; }
        public Human() { }
        public Human(string name, string age, string id)
        {
            this.fullName = name;
            this.valueOfAge = age;
            this.valueOfId = id;
        }
        public object truyvanDB(params object[] thamso)
        {
            Database db = new Database();
            db.queryEvent += Db_queryEvent;
            db.Query(thamso);
            return thamso[0];

        }
        private object Db_queryEvent(params object[] pas)
        {
            return "nhan thong bao tu he thong";
        }
        public Human(Human human)
        {
            this.fullName = human.fullName;
            this.valueOfAge = human.valueOfAge;
            this.valueOfId = human.valueOfId;
        }
        public virtual object CheckIn(params object[] pas) //pas == parameters
        {
            return "\nCheck in";
        }
        public virtual object CheckOut(params object[] pas)
        {
            return "\nCheck out";
        }
    }
}
