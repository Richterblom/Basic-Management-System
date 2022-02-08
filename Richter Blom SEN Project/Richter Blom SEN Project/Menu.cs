using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Richter_Blom_SEN_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client_Management cm = new Client_Management();
            cm.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            Product_Management pm = new Product_Management();
            pm.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Technicians_Management tm = new Technicians_Management();
            tm.Show();
            this.Hide();
        }

        private void btncontrractmgmnet_Click(object sender, EventArgs e)
        {
            Contract_Managment cm = new Contract_Managment();
            cm.Show();
            this.Hide();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            Call_Centre cc = new Call_Centre();
            cc.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
