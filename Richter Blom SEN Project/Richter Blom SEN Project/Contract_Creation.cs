using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace Richter_Blom_SEN_Project
{
    public partial class Contract_Creation : Form
    {
        public Contract_Creation()
        {
            InitializeComponent();
        }
        List<Clients> clientList = new List<Clients>();
        List<Products> productList = new List<Products>();
        List<Contract> contractList = new List<Contract>();
        Clients client = new Clients();
        Products products = new Products();
        Contract contracts = new Contract();
        BindingSource bsc = new BindingSource();
        BindingSource bsp = new BindingSource();
        private void Contract_Creation_Load(object sender, EventArgs e)
        {
            clientList = client.ReInfo();
            productList = products.ReInfo();
            contractList = contracts.ReInfo();
            //client
            bsc.DataSource = clientList;
            dgvClient.DataSource = bsc;
            //product
            bsp.DataSource = productList;
            dgvProduct.DataSource = bsp;

            //updateContracts
            foreach (Contract con in contractList)
            {
                if (con.StartDate.AddMonths(con.ContactDuration) <= DateTime.Now)
                {
                    contracts.Update(con.ID, "Status", "inactive");
                    contracts.Update(con.NextContract, "Status", "active");
                }
            }
        }

        private void btnConfirmContract_Click(object sender, EventArgs e)
        {
            Clients currentClient = (Clients)dgvClient.CurrentRow.DataBoundItem;
            Products currentProduct = (Products)dgvProduct.CurrentRow.DataBoundItem;
            contractList = contracts.ReInfo();
            Contract contractcount = contractList[contractList.Count - 1];
            string nextContract = null;
           
            
                int newid = int.Parse(contractcount.ID.Substring(6, 6)) + 1;
                int length = 6 - newid.ToString().Length;
                string zero = "";
                for (int i = length; i > 0; i--)
                {
                    zero += "0";
                }
                DateTime date = DateTime.Now;
                int year = date.Year;
                string finalID = year.ToString() + cbSeviceLevel.Text.Substring(0, 1).ToUpper() + cbContractType.Text.Substring(0, 1).ToUpper() + zero + newid.ToString();
                foreach (Contract c in contractList)
                     {
                if (c.ClientID == currentClient.ID && c.Status == "active")
                {
                    contracts.Update(c.ID, "NextContract", finalID);
                }
                     }
                contracts.Insert(finalID, DateTime.Now, int.Parse(txtContractDur.Text), cbSeviceLevel.Text, cbContractType.Text, "active", currentClient.ID, currentProduct.ID,null);
                Contract_Managment cm = new Contract_Managment();
                cm.Show();
                this.Close();
        }

        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
