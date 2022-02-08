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
    public partial class Call_Logs : Form
    {
        public Call_Logs()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        CallLogs callLogs = new CallLogs();
        List<CallLogs> callLogsList = new List<CallLogs>();

        private void Call_Logs_Load(object sender, EventArgs e)
        {
            callLogsList = callLogs.ReInfo(); 
            bs.DataSource = callLogsList;
            dgvCallLogs.DataSource = bs;

            refresh();
        }
        public void refresh()
        {
            dgvCallLogs.Columns["ID"].Visible = false;
        }

        private void btnBackCallCentre_Click(object sender, EventArgs e)
        {
            Call_Centre cl = new Call_Centre();
            cl.Show();
            this.Close();
        }

        private void btnNextDept_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
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
            List<CallLogs> callLogsList = callLogs.ReInfo();
            List<CallLogs> newcallLogsList = new List<CallLogs>();
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                refresh();
            }
            else
            {
                foreach (CallLogs cl in callLogsList)
                {
                    //string comparsion gets string in textbox ignoring upper and lower case
                    //checks name or surname contains same values as string in searchbox in that order
                    if (cl.Client_ID.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0 || cl.Technician_Assigned.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        //checks to see the first person match what is here then adds to new list and display
                        newcallLogsList.Add(cl);
                    }
                }
                bs.DataSource = newcallLogsList;
                dgvCallLogs.DataSource = bs;
                dgvCallLogs.Refresh();
            }
        }
    }
}
