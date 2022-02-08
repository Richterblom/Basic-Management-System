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
    public partial class Product_Management : Form
    {
        public Product_Management()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Products products = new Products();
        private void Product_Managment_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            bs.DataSource = products.ReInfo();
            dgvProducts.DataSource = bs;
            dgvProducts.Refresh();
            dgvProducts.Columns["ID"].Visible = false;
        }

        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            Product_Details pd = new Product_Details();
            pd.Show();
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the name of the product");
                txtName.Focus();
            }
            else if (txtPrice.Text == ""|| !txtPrice.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter the price of the product");
                txtPrice.Focus();
            }
            else if (txtEstTime.Text == "" || !txtEstTime.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter estimated maintanence time needed");
                txtEstTime.Focus();
            }
            else if (txtManufacturer.Text == "" || txtManufacturer.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter manufacturer name");
                txtManufacturer.Focus();
            }
            else if (txtModelName.Text == "" )
            {
                MessageBox.Show("Please enter model name");
                txtModelName.Focus();
            }
            else if (txtSerialNumber.Text == "" || !txtSerialNumber.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter serial number name");
                txtSerialNumber.Focus();
            }
            else
            {
                //code to save
                if (products.InsertProduct(txtManufacturer.Text + txtModelName.Text + txtSerialNumber.Text,txtName.Text, Convert.ToDouble(txtPrice.Text), int.Parse(txtEstTime.Text),txtManufacturer.Text,txtModelName.Text,txtSerialNumber.Text))
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
            List<Products> productList = products.ReInfo();
            List<Products> newproductlist = new List<Products>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (Products client in productList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (client.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 )
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newproductlist.Add(client);
                    }
                }
                bs.DataSource = newproductlist;
                dgvProducts.DataSource = bs;
                dgvProducts.Refresh();
            }
        }
    }
}
