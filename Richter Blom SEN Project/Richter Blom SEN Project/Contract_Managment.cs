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
    public partial class Contract_Managment : Form
    {
        public Contract_Managment()
        {
            InitializeComponent();
        }
        
        List<Contract> contractList = new List<Contract>();
        
        Contract contracts = new Contract();
        BindingSource bs = new BindingSource();
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Contract_Creation cc = new Contract_Creation();
            cc.Show();
            this.Close();
        }

        public void refresh()
        {
            bs.DataSource = contracts.ReInfo();
            dgvContract.DataSource = bs;
            dgvContract.Refresh();
        }

        private void Contract_Managment_Load(object sender, EventArgs e)
        {

            contractList = contracts.ReInfo();
            bs.DataSource = contractList;
            dgvContract.DataSource = bs;
          
        }
        //update button
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Contract currentcontract = (Contract)dgvContract.CurrentRow.DataBoundItem;
            bool check = true;
            if (txtJobDur.Text == "" || !txtJobDur.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter duration of job");
                txtJobDur.Focus();
            }
            else
            {
                check = Update(txtJobDur.Text, "Contract_Duration");
            }
            if (cbSeviceLevel.Text == currentcontract.SeviceLevel)
            {
                MessageBox.Show("contract service level already " + cbSeviceLevel.Text);
            }
            else
            {
                check = Update(cbSeviceLevel.Text, "Service_Level");
            }
            if (cbContractType.Text == currentcontract.ContractType)
            {
                MessageBox.Show("contract type " + cbContractType.Text + " already exist ");
            }
            else
            {
                check = Update(cbContractType.Text, "Contract_Type");
            }
            if (cbStatus.Text == currentcontract.Status)
            {
                MessageBox.Show("status " + cbStatus.Text + " already exists ");
            }
            else
            {
                check = Update(cbStatus.Text, "Status");
            }
            refresh();
        }
        public bool Update(string item, string columnName)
        {
            bool check = true;
            try
            {
                Contract person = (Contract)dgvContract.CurrentRow.DataBoundItem;
                check = contracts.Update(person.ID, columnName, item);
            }
            catch (Exception)
            {

                check = false;
            }

            return check;
        }
        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }


        private void dgvContract_SelectionChanged(object sender, EventArgs e)
        {
            //ignores the error with search function
            try
            {
                Contract person = (Contract)dgvContract.CurrentRow.DataBoundItem;
                txtJobDur.Text = person.ContactDuration.ToString();
                cbSeviceLevel.Text = person.SeviceLevel;
                cbContractType.Text = person.ContractType;
                cbStatus.Text = person.Status;
            }
            catch (Exception)
            {


            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //gets list of clients then filters to new client list
            List<Contract> contractList = contracts.ReInfo();
            List<Contract> newcontractlist = new List<Contract>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (Contract contract in contractList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (contract.ContractType.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 )
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newcontractlist.Add(contract);
                    }
                }
                bs.DataSource = newcontractlist;
                dgvContract.DataSource = bs;
                dgvContract.Refresh();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
        }
    }
}
