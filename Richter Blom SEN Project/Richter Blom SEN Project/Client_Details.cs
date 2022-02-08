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
using System.Reflection;

namespace Richter_Blom_SEN_Project
{
    public partial class Client_Details : Form
    {
        public Client_Details()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Clients client = new Clients();

        private void Client_Details_Load(object sender, EventArgs e)
        {
            refresh();
           
        }
        public void refresh()
        {
            bs.DataSource = client.ReInfo();
            dgvClients.DataSource = bs;
            dgvClients.Refresh();
            dgvClients.Columns["ID"].Visible = false;
           // dgvClients.Rows[0].Selected = false;
        }

        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Client_Management cm = new Client_Management();
            cm.Show();
            this.Close();
        }
        //just to show how it would work if the update was implemented
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtName.Text == "" || txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your name");
                txtName.Focus();
            }
            else
            {
                check = Update(txtName.Text, "Client_Name");

            }
            if (txtSurname.Text == "" || txtSurname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your surname");
                txtName.Focus();
            }
            else
            {
                check = Update(txtSurname.Text, "Client_Surname");
            }
            //doesnt have num throw error
            if (txtAddress.Text == "" || !txtAddress.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your address");
                txtName.Focus();
            }
            else
            {
                check = Update(txtAddress.Text, "Address");
            }
            //see if all number
            if (txtPhoneNumber.Text == "" || !txtPhoneNumber.Text.All(char.IsDigit) || txtPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter your phone number");
                txtName.Focus();
            }
            else
            {
                check = Update(txtPhoneNumber.Text, "Client_Phone_Number");
            }
           
            if (cbStatus.Text == "")
            {
                MessageBox.Show("Please select a status type");
                txtName.Focus();
            }
            else
            {
                check = Update(cbStatus.Text, "Status");
            }
            refresh();
            if (check)
            {
                MessageBox.Show("Client has been updated ");
            }
            else
            {
                MessageBox.Show("Client update has failed please Select the information you wish to change");
            }
        }
        public bool Update(string item, string columnName)
        {
            bool check = true;
            try
            {
                Clients person = (Clients)dgvClients.CurrentRow.DataBoundItem;
                check = client.Update(person.ID, columnName, item);
            }
            catch (Exception)
            {
                //throw;
                check = false;
            }
           
            return check;
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            //ignores the error with search function
            try
            {
                Clients person = (Clients)dgvClients.CurrentRow.DataBoundItem;
                txtName.Text = person.Name;
                txtSurname.Text = person.Surname;
                txtAddress.Text = person.Address;
                txtPhoneNumber.Text = person.PhoneNumber;
               
                cbStatus.Text = person.Status;
            }
            catch (Exception)
            {

                
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //gets list of clients then filters to new client list
            List<Clients> clientList = client.ReInfo();
            List<Clients> newclientlist = new List<Clients>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (Clients client in clientList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (client.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || client.Surname.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || client.Status.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newclientlist.Add(client);
                    }
                }
                bs.DataSource = newclientlist;
                dgvClients.DataSource = bs;
                dgvClients.Refresh();
            }
        }
    }
}
