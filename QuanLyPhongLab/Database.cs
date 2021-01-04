using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyPhongLab
{
    public class Database
    {
        public DataType typeOfDateBase { get; set; }
        public string passwordOfDB { get; set; }
        public string nameDB { get; set; }
        public List<Camera> listCamera { get; set; }
        public List<Manager> listManager { get; set; }
        public List<Chair> listChair { get; set; }
        public List<Desk> listDesk { get; set; }
        public List<Keyboard> listKeyboard { get; set; }
        public List<Mouse> listMouse { get; set; }
        public List<PC> listPC { get; set; }
        public List<Screen> listScreen { get; set; }
        public List<ServerModel> listServer { get; set; }
        public List<Television> listTelevision { get; set; }
        public List<Cabinet> listCabinet { get; set; }
        public Database()
        {
            listCamera = new List<Camera>();
            listChair = new List<Chair>();
            listDesk = new List<Desk>();
            listKeyboard = new List<Keyboard>();
            listMouse = new List<Mouse>();
            listPC = new List<PC>();
            listScreen = new List<Screen>();
            listServer = new List<ServerModel>();
            listTelevision = new List<Television>();
        }
        public Database(string pass, string name)
        {
            this.passwordOfDB = pass;
            this.nameDB = name;
        }
        public Database(List<Camera> listcam, List<Chair> listchair,
            List<Desk> listdesk, List<Keyboard> listkeyboard,
            List<Mouse> listmouse, List<PC> listpc, List<Screen> listscreen,
            List<ServerModel> listserver, List<Television> listtele, List<User> listuser, List<Cabinet> listcabinets) : this()
        {
            foreach (var cam in listcam)
                this.listCamera.Add(new Camera(cam));
            foreach (var chair in listchair)
                this.listChair.Add(new Chair(chair));
            foreach (var desk in listdesk)
                this.listDesk.Add(new Desk(desk));
            foreach (var keyboard in listkeyboard)
                this.listKeyboard.Add(new Keyboard(keyboard));
            foreach (var mouse in listmouse)
                this.listMouse.Add(new Mouse(mouse));
            foreach (var pc in listpc)
                this.listPC.Add(new PC(pc));
            foreach (var screen in listscreen)
                this.listScreen.Add(new Screen(screen));
            foreach (var server in listserver)
                this.listServer.Add(new ServerModel(server));
            foreach (var tele in listtele)
                this.listTelevision.Add(new Television(tele));
        }
        public Database(Database db)
        {
            foreach (var cam in db.listCamera)
                this.listCamera.Add(new Camera(cam));
            foreach (var chair in db.listChair)
                this.listChair.Add(new Chair(chair));
            foreach (var desk in db.listDesk)
                this.listDesk.Add(new Desk(desk));
            foreach (var keyboard in db.listKeyboard)
                this.listKeyboard.Add(new Keyboard(keyboard));
            foreach (var mouse in db.listMouse)
                this.listMouse.Add(new Mouse(mouse));
            foreach (var pc in db.listPC)
                this.listPC.Add(new PC(pc));
            foreach (var screen in db.listScreen)
                this.listScreen.Add(new Screen(screen));
            foreach (var server in db.listServer)
                this.listServer.Add(new ServerModel(server));
            foreach (var tele in db.listTelevision)
                this.listTelevision.Add(new Television(tele));
        }
        protected bool OpenConnection(params object[] pas)
        {
            return true;
        }
        protected object SelectDB(params object[] pas)
        {
            return "Select database";
        }
        protected object SelectTable(params object[] pas)
        {
            return "Select table";
        }
        public delegate object queryHandel(params object[] pas);
        public event queryHandel queryEvent;
        protected object ExcuteQuery(params object[] pas)
        {
            return queryEvent?.Invoke(pas);
        }
        protected object CloseConnection(params object[] pas)
        {
            return "Close connection";
        }
        public virtual object Query(params object[] pas)
        {
            try
            {
                this.OpenConnection();
            }catch(Exception error)
            {
                return error;
            }
            object db = this.SelectDB();
            object tb = this.SelectTable(db);
            object result = this.ExcuteQuery(tb,pas);
            this.CloseConnection(db);
            return result;
        }
    }
}
