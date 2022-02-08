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
    public partial class Client_Management : Form
    {
        public Client_Management()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Clients client = new Clients();
        List<Clients> clients = new List<Clients>();
        private void Client_Management_Load(object sender, EventArgs e)
        {
            refresh();
            
        }
        public void refresh()
        {
            clients = client.ReInfo();
            bs.DataSource = clients;
            dgvClients.DataSource = bs;
            dgvClients.Refresh();
            txtName.Clear();
            txtSurname.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
           // dgvClients.Columns["ID"].Visible = false;
            
        }
        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            Client_Details cd = new Client_Details();
            cd.Show();
            this.Close();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your name");
                txtName.Focus();
            }
            else if (txtSurname.Text == "" || txtSurname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your surname");
                txtSurname.Focus();
            }
            else if (txtAddress.Text == "" || !txtAddress.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter your address");
                txtAddress.Focus();
            }
            else if (txtPhoneNumber.Text == "" || !txtPhoneNumber.Text.All(char.IsDigit) || txtPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter your phone number");
                txtPhoneNumber.Focus();
            }
            else
            {
                Clients clientcount = clients[clients.Count - 1];
                string L = GetLetter().ToString();
                    //txtName.Text.Substring(0,1).ToUpper();
                int newid = int.Parse(clientcount.ID.Substring(1,8)) + 1;
                int length = 8 - newid.ToString().Length;
                string zero = "";
                for (int i = length; i > 0; i--)
                {
                    zero += "0";
                }
                string finalID = L + zero + newid.ToString();
                //code to insert
                if (client.InsertClients(finalID, txtName.Text, txtSurname.Text, txtAddress.Text, txtPhoneNumber.Text,cbStatus.Text))
                {
                    MessageBox.Show("Information added to the system");
                }
                else
                {
                    MessageBox.Show("Information failed to add to the system");

                } 
            }
            refresh();
        }
        public static char GetLetter()
        {
            string chars = "ABCD";
            Random rand = new Random();
            int num = rand.Next(0, chars.Length - 1);
            return chars[num];
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
       
        private void txtSerach_TextChanged(object sender, EventArgs e)
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
                    if (client.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase)>=0 || client.Surname.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || client.Status.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clients c = (Clients)dgvClients.CurrentRow.DataBoundItem;
            client.Update(c.ID, "Status", "Inactive");
            refresh();
        }
    }
}
