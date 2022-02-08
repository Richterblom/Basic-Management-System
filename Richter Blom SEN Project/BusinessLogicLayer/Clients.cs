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
    public class Clients
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
      
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        public Clients(string id, string name,string surname, string address, string phoneNumber,string status)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phoneNumber = phoneNumber;
           
            this.status = status;
            
        }
        public Clients()
        {

        }
        //read class modified
        //calls info from datahandler class in business logic layer
        DataHandler dh = new DataHandler();
        public List<Clients> ReInfo()
        {
            List<Clients> clientslist = new List<Clients>();
            //DataSet clientinfo = new UserDataHandler().Read();
            DataTable clientinfo = new DataHandler().Read("Client");
            foreach (DataRow item in clientinfo.Rows)
            {
                    clientslist.Add(new Clients(item["ID"].ToString(),
                    item["Client_Name"].ToString(),
                    item["Client_Surname"].ToString(),
                    item["Address"].ToString(),
                    item["Client_Phone_Number"].ToString(),
                    item["Status"].ToString()));
            }
            return clientslist;
        }
        public bool InsertClients(string id, string name, string surname, string address, string phoneNum, string status)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
            columnName.Add("ID");
            columnName.Add("Client_Name");
            columnName.Add("Client_Surname");
            columnName.Add("Address");
            columnName.Add("Client_Phone_Number");
            columnName.Add("Status");
            //-------------------------
            values.Add(id);
            values.Add(name);
            values.Add(surname);
            values.Add(address);
            values.Add(phoneNum);
           
            values.Add(status);
            check =  dh.insert("Client_tbl",columnName,values);
            return check;
        }

        public bool Update(string id, string colName, string newValue)
        {
            bool check = true;
            //all action is happening in datahandler
            check =dh.UpdateC(id, colName, newValue, "Client_tbl");
            return check;
        }
       
    }
}
