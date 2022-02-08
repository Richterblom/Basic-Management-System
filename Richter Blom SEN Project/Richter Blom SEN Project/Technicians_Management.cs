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
    public partial class Technicians_Management : Form
    {
        public Technicians_Management()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Technicians tech = new Technicians();
        private void Technicians_department_Load(object sender, EventArgs e)
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

      

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Technicians_Details td = new Technicians_Details();
            td.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the name of the technician");
                txtName.Focus();
            }
            else if (txtSurname.Text == "" || txtSurname.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the surname of the technician");
                txtName.Focus();
            }
            else if (txtNumber.Text == "" || !txtNumber.Text.All(char.IsDigit) || txtNumber.Text.Length !=10)
            {
                MessageBox.Show("Please enter the phone number of the technician");
                txtName.Focus();
            }
            else
            {
                //code to save
               
                if (tech.InsertTech(txtName.Text, txtSurname.Text, txtNumber.Text))
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
        public void Update(string item, string columnName)
        {
            Technicians tech = (Technicians)dgvMaintenence.CurrentRow.DataBoundItem;
            tech.Update(tech.ID, columnName, item);
        }
        private void dgvMaintenence_SelectionChanged(object sender, EventArgs e)
        {
          //not used
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
