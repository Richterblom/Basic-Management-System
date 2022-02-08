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
    public class CallLogs
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string client_ID;

        public string Client_ID
        {
            get { return client_ID; }
            set { client_ID = value; }
        }
        private DateTime start_time;

        public DateTime Start_Time
        {
            get { return start_time; }
            set { start_time = value; }
        }
        private DateTime end_Date;

        public DateTime End_Date
        {
            get { return end_Date; }
            set { end_Date = value; }
        }
        private string time_taken;

        public string Time_taken
        {
            get { return time_taken; }
            set { time_taken = value; }
        }
        private string technician_Assigned;

        public string Technician_Assigned
        {
            get { return technician_Assigned; }
            set { technician_Assigned = value; }
        }


        public CallLogs(int id,string clientid,DateTime start,DateTime end,string taken,string Technician_Assigned)
        {
            this.id = id;
            this.client_ID = clientid;
            this.start_time = start;
            this.end_Date = end;
            this.time_taken = taken;
            this.technician_Assigned = Technician_Assigned;
        }
        public CallLogs()
        {

        }
        DataHandler dh = new DataHandler();
        public List<CallLogs> ReInfo()
        {
            List<CallLogs> contractlist = new List<CallLogs>();

            DataTable contractinfo = new DataHandler().Read("Call_Log");
            foreach (DataRow item in contractinfo.Rows)
            {
                contractlist.Add(new CallLogs(int.Parse(item["ID"].ToString()),
                (item["Client_ID"].ToString()),
                 Convert.ToDateTime(item["Start_Time"].ToString()),
                 Convert.ToDateTime( item["End_Time"].ToString()),
                  (item["Time_Taken"].ToString()),
                  (item["Tech_FullName"].ToString())));
            }
            return contractlist;
        }
        public bool Insert(string clientID,DateTime start,DateTime end ,string taken, string Technician_Assigned)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
            
            columnName.Add("Client_ID");
            columnName.Add("Start_Time");
            columnName.Add("End_Time");
            columnName.Add("Time_Taken");
            columnName.Add("Tech_FullName");
            //-------------------------

            values.Add(clientID.ToString());
            values.Add(start.ToString());
            values.Add(end.ToString());
            values.Add(taken);
            values.Add(Technician_Assigned);

            check = dh.insert("Call_Log_tbl", columnName, values);
            return check;
        }
    }
}
