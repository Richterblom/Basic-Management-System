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
    public class Technicians
    {
        private int id;

        public int ID
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
       
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
       


        public Technicians(int id, string name, string surname, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
           
        }
        public Technicians()
        {

        }
        //read class modified
        //calls info from datahandler class in business logic layer
        public List<Technicians> ReInfo()
        {
            List<Technicians> techlist = new List<Technicians>();
            // DataSet techInfo = new UserDataHandler().Read();
            DataTable techInfo = new DataHandler().Read("Technician");
            foreach (DataRow item in techInfo.Rows)
            {
                techlist.Add(new Technicians(int.Parse(item["ID"].ToString()),
                item["Tech_Name"].ToString(),
                item["Tech_Surname"].ToString(),
                item["Tech_Phone_Number"].ToString()));
            }
            return techlist;
        }
        public bool InsertTech(string name, string surname, string num)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
            columnName.Add("Tech_Name");
            columnName.Add("Tech_Surname");
            columnName.Add("Tech_Phone_Number");
            
           
            values.Add(name);
            values.Add(surname);
            values.Add(num);
            
           
            check = dh.insert("Technician_tbl", columnName, values);
            return check;
           
        }
        DataHandler dh = new DataHandler();
        public bool Update(int id, string colName, string newValue)
        {
            bool check = true;
            string converter = id.ToString();
            //all action is happening in datahandler
            check = dh.UpdateC(converter, colName, newValue, "Technician_tbl");
            return check;
        }
        public void maintainace()
        {
            //do they want maintainace yes or no sends info to technical
        }
        public void installations()
        {
            //when are updates needed 
        }
    }
}
