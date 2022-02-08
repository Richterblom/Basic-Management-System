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
    public partial class Product_Details : Form
    {
        public Product_Details()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Products products = new Products();
        private void Product_Details_Load(object sender, EventArgs e)
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

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product_Management pm = new Product_Management();
            pm.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the name of the product");
                txtName.Focus();
            }
            else {
                check = Update(txtName.Text, "Product_Name");
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please enter the price of the product");
                txtName.Focus();
            }
            else {
                check = Update(txtPrice.Text, "Product_Price");
            }
            if (txtEstTime.Text == "")
            {
                MessageBox.Show("Please enter estimated maintanence time needed");
                txtName.Focus();
            }
            else
            {
                check = Update(txtEstTime.Text, "Estimate_Maintenance");
            }
           
            refresh();
            if (check)
            {
                MessageBox.Show("Prooduct has been updated ");
            }
            else
            {
                MessageBox.Show("Product update has failed please make sure you selected the information you wish to change");
            }
        }
        public bool Update(string item, string columnName)
        {
            bool check = true;
            try
            {
                
                Products prod = (Products)dgvProducts.CurrentRow.DataBoundItem;
                check = products.Update(prod.ID, columnName, item);
              
            }
            catch (Exception)
            {
                check = false;

            }
            return check;
        }
        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Products prod = (Products)dgvProducts.CurrentRow.DataBoundItem;
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();
                txtEstTime.Text = prod.Estimatemainanence.ToString();
               
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
            List<Products> prodList = products.ReInfo();
            List<Products> newprodlist = new List<Products>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (Products prod in prodList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (prod.Name.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 )
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newprodlist.Add(prod);
                    }
                }
                bs.DataSource = newprodlist;
                dgvProducts.DataSource = bs;
                dgvProducts.Refresh();
            }
        }
    }
}
