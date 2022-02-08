using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Collections;

namespace BusinessLogicLayer
{
    public class Appointments
    {
        private int appID;

        public int AppID
        {
            get { return appID; }
            set { appID = value; }
        }
        private DateTime dateoApp;

        public DateTime DateOApp
        {
            get { return dateoApp; }
            set { dateoApp = value; }
        }
        private string typeOApp;

        public string TypeOApp
        {
            get { return typeOApp; }
            set { typeOApp = value; }
        }
        private string compStatus;

        public string CompStatus
        {
            get { return compStatus; }
            set { compStatus = value; }
        }
        private string techAssigned;

        public string TechAssigned
        {
            get { return techAssigned; }
            set { techAssigned = value; }
        }
        public Appointments(int AppID,DateTime DateOApp,string TypeOApp,string CompStatus,string TechAssigned)
        {
            this.appID = AppID;
            this.dateoApp = DateOApp;
            this.typeOApp = TypeOApp;
            this.compStatus = CompStatus;
            this.techAssigned = TechAssigned;
        }
        public Appointments()
        {

        }
        //read class modified
        //calls info from datahandler class in business logic layer
        DataHandler dh = new DataHandler();

        public List<Appointments> ReInfo()
        {
            List<Appointments> appslist = new List<Appointments>();
            //DataSet clientinfo = new UserDataHandler().Read();
            DataTable appinfo = new DataHandler().Read("Appointment");
            foreach (DataRow item in appinfo.Rows)
            {
                appslist.Add(new Appointments(int.Parse(item["ID"].ToString()),
                Convert.ToDateTime(item["DateOApp"].ToString()),
                item["TypeOApp"].ToString(),
                item["CompStatus"].ToString(),
                item["TechAssigned"].ToString()));
            }
            return appslist;
        }
        public bool Insertapp(DateTime DateOApp, string TypeOApp, string CompStatus, string TechAssigned)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
       
            columnName.Add("DateOApp");
            columnName.Add("TypeOApp");
            columnName.Add("CompStatus");
            columnName.Add("TechAssigned");
            //-------------------------
       
            values.Add(DateOApp.ToString());
            values.Add(TypeOApp);
            values.Add(CompStatus);
            values.Add(TechAssigned);

           
            check = dh.insert("Appointment_tbl", columnName, values);
            return check;
        }

        public bool Update(string id, string colName, string newValue)
        {
            bool check = true;
            //all action is happening in datahandler
            check = dh.UpdateC(id, colName, newValue, "Appointment_tbl");
            return check;
        }

        public bool Delete(int ID)
        {
            bool check = true;
            //all action is happening in datahandler
            check = dh.Delete("Appointment", ID);
            return check;
        }
    }
}
