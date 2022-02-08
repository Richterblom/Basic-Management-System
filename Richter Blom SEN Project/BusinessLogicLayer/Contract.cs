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
    public class Contract
    {
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime startedate;

        public DateTime StartDate
        {
            get { return startedate; }
            set { startedate = value; }
        }
        private int contactDuration;

        public int ContactDuration
        {
            get { return contactDuration; }
            set { contactDuration = value; }
        }

        private string serviceLevel;

        public string SeviceLevel
        {
            get { return serviceLevel; }
            set { serviceLevel = value; }
        }
        private string contractType;

        public string ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string clientid;

        public string ClientID
        {
            get { return clientid; }
            set { clientid = value; }
        }
        private string productid;

        public string ProductID
        {
            get { return productid; }
            set { productid = value; }
        }
        private string nextcontract;

        public string NextContract
        {
            get { return nextcontract; }
            set { nextcontract = value; }
        }

        public Contract(string Id,DateTime Startdate,int ContractDuration,string ServiceLvl,string ContractType,string Status,string ClientID, string ProductID,string NextContract)
        {
            this.id = Id;
            this.startedate = Startdate;
            this.contactDuration = ContractDuration;
            this.serviceLevel = ServiceLvl;
            this.contractType = ContractType;
            this.status = Status;
            this.clientid = ClientID;
            this.productid = ProductID;
            this.nextcontract = NextContract;
        }
        public Contract()
        {

        }
        DataHandler dh = new DataHandler();
        public List<Contract> ReInfo()
        {
            List<Contract> contractlist = new List<Contract>();
           
            DataTable contractinfo = new DataHandler().Read("Contract");
            foreach (DataRow item in contractinfo.Rows)
            {
                contractlist.Add(new Contract(item["ID"].ToString(),
                Convert.ToDateTime(item["Contract_Start"].ToString()),
                int.Parse(item["Contract_Duration"].ToString()),
                item["Service_Level"].ToString(),
                item["Contract_Type"].ToString(),
                item["Status"].ToString(),
                item["Client_ID"].ToString(),
                item["Product_ID"].ToString(),
                 item["NextContract"].ToString()));
            }
            return contractlist;
        }
        public bool Insert(string id, DateTime Startdate,int duration, string servicelvl, string ContractType, string Status, string ClientID, string ProductID,string nextContract)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
            columnName.Add("ID");
            columnName.Add("Contract_Start");
            columnName.Add("Contract_Duration");
            columnName.Add("Service_Level");
            columnName.Add("Contract_Type");
            columnName.Add("Status");
            columnName.Add("Client_ID");
            columnName.Add("Product_ID");
            columnName.Add("NextContract");
            //-------------------------
            values.Add(id);
            values.Add(Startdate.ToString());
            values.Add(duration.ToString());
            values.Add(servicelvl);
            values.Add(ContractType);
            values.Add(Status);
            values.Add(ClientID);
            values.Add(ProductID.ToString());
            values.Add(nextContract);
            check = dh.insert("Contract_tbl", columnName, values);
            return check;
        }
        public bool Update(string id, string colName, string newValue)
        {
            bool check = true;
            //all action is happening in datahandler
            check = dh.UpdateC(id, colName, newValue, "Contract_tbl");
            return check;
        }
    }
}
