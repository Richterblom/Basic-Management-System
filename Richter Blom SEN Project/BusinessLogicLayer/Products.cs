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
    public class Products
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
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int estimatemainanence;

        public int Estimatemainanence
        {
            get { return estimatemainanence; }
            set { estimatemainanence = value; }
        }
        private string manufacturer;

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        private string modelName;

        public string ModelName
        {
            get { return modelName; }
            set { modelName = value; }
        }
        private string serialNumber;

        public string SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }


        public Products(string id, string name,double price, int estimatemainanence,string manufacturer,string modelName,string serialNumber)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.estimatemainanence = estimatemainanence;
            this.manufacturer = manufacturer;
            this.modelName = modelName;
            this.serialNumber = serialNumber;
        }
        public Products()
        {

        }
        //read class modified
        //calls info from datahandler class in business logic layer
        public List<Products> ReInfo()
        {
            List<Products> Productlist = new List<Products>();
            // DataSet productinfo = new UserDataHandler().Read();
            DataTable productinfo = new DataHandler().Read("Product");
            foreach (DataRow item in productinfo.Rows)
            {
                Productlist.Add(new Products(item["ID"].ToString(),
                item["Product_Name"].ToString(),
                int.Parse(item["Product_Price"].ToString()),
                int.Parse(item["Estimate_Maintenance"].ToString()),
                (item["Manufacturer"].ToString()),
                (item["Model_Name"].ToString()),
                (item["Serial_Number"].ToString())));
            }
            return Productlist;
        }
        public bool InsertProduct(string ID,string name, double price, int estmaine,string manufacturer,string ModelName,string Serial_Number)
        {
            bool check = true;
            List<string> columnName = new List<string>();
            List<string> values = new List<string>();
            columnName.Add("ID");
            columnName.Add("Product_Name");
            columnName.Add("Product_Price");
            columnName.Add("Estimate_Maintenance");
            columnName.Add("Manufacturer");
            columnName.Add("Model_Name");
            columnName.Add("Serial_Number");

            values.Add(ID);
            values.Add(name);
            values.Add(price.ToString());
            values.Add(estmaine.ToString());
            values.Add(manufacturer.ToString());
            values.Add(ModelName.ToString());
            values.Add(Serial_Number.ToString());

            check = dh.insert("Product_tbl", columnName, values);
            return check;
          
        }
        DataHandler dh = new DataHandler();

        public bool Update(string id, string colName, string newValue)
        {
            bool check = true;
            //all action is happening in datahandler
            check = dh.UpdateC(id, colName, newValue, "Product_tbl");
            return check;
        }
    }
}
