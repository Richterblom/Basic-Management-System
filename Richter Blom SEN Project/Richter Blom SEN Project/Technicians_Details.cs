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
    public partial class Technicians_Details : Form
    {
        public Technicians_Details()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Technicians tech = new Technicians();

        private void Technicians_Details_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            bs.DataSource = tech.ReInfo();
            dgvMaintenence.DataSource = bs;
            dgvMaintenence.Refresh();
            dgvMaintenence.Columns["ID"].Visible = false;
        }

        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Technicians_Management tm = new Technicians_Management();
            tm.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtName.Text == "" || txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the name of the technician");
                txtName.Focus();
            }
            else
            {
                check = Update(txtName.Text, "Tech_Name");
            }
            if (txtSurname.Text == "" || txtSurname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the surname of the technician");
                txtName.Focus();
            }
            else
            {
                check = Update(txtSurname.Text, "Tech_Surname");
            }
             if (txtNumber.Text == "" || !txtNumber.Text.All(char.IsDigit) || txtNumber.Text.Length != 10)
            {
                MessageBox.Show("Please enter the phone number of the technician");
                txtName.Focus();
            }
            else
            {
                check = Update(txtNumber.Text, "Tech_Phone_Number");
            }
            refresh();
            if (check)
            {
                MessageBox.Show("technician has been updated ");
            }
            else
            {
                MessageBox.Show("technician update has failed please Select the information you wish to change");
            }
        }
        public bool Update(string item, string columnName)
        {
            bool check = true;
            try
            {
                Technicians techp = (Technicians)dgvMaintenence.CurrentRow.DataBoundItem;
                check = tech.Update(techp.ID, columnName, item);
            }
            catch (Exception)
            {

                check = false;
            }
           
            return check;
        }
        private void dgvMaintenence_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Technicians techp = (Technicians)dgvMaintenence.CurrentRow.DataBoundItem;
                txtName.Text = techp.Name;
                txtSurname.Text = techp.Surname;
                txtNumber.Text = techp.PhoneNumber;
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
            List<Technicians> techList = tech.ReInfo();
            List<Technicians> newtechlist = new List<Technicians>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (Technicians tech in techList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (tech.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || tech.Surname.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newtechlist.Add(tech);
                    }
                }
                bs.DataSource = newtechlist;
                dgvMaintenence.DataSource = bs;
                dgvMaintenence.Refresh();
            }
        }
    }
}
