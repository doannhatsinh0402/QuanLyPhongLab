using System;
using System.Diagnostics;

namespace QuanLyPhongLab
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDatabase();
        }
        public static void TestCamera()
        {
            Camera a = new Camera();
            Console.WriteLine(a.xoayCamera(a.xoayPhai, 89));
        }
        public static void TestDatabase()
        {
            Database db = new Database();
            db.queryEvent += Db_queryTest;
            Console.WriteLine(db.Query());
        }
        private static object Db_queryTest(params object[] pas) // pas[0] la table
        {
            return "truy van vi du";
        }
        public static void TestManager()
        {
            Manager a = new Manager("123","123");
            Device b = new Camera();
            a.SignIn();
        }
    }
}
