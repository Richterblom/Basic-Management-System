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
    public partial class Call_Centre : Form
    {
        public Call_Centre()
        {
            InitializeComponent();
        }
        CallLogs CL= new CallLogs();
        DateTime start;
        Clients client = new Clients();
        Appointments appointment = new Appointments();
        List<Clients> clientList = new List<Clients>();
        List<Appointments> applist = new List<Appointments>();
        BindingSource bsC = new BindingSource();
        BindingSource bsA = new BindingSource();

        private void Call_Centre_Load(object sender, EventArgs e)
        {
            clientList = client.ReInfo();
            applist = appointment.ReInfo();
            bsC.DataSource = clientList;
            bsA.DataSource = applist;
            dgvClients.DataSource = bsC;


            Technicians tech = new Technicians();
            List<Technicians> TechList = tech.ReInfo();
            List<string> TechNames = new List<string>();
            foreach (Technicians t in TechList)
            {
                TechNames.Add(t.Name + " " + t.Surname);
            }
            TechNames.Add("None");
            cmbTechnicianAssigned.DataSource = TechNames;
            
            refresh();
        }
        public void refresh()
        {
            applist = appointment.ReInfo();
             dgvClients.Columns["ID"].Visible = false;
             dgvClients.Columns["Status"].Visible = false;

            twAppointments.Nodes.Clear();
            twAppointments.Nodes.Add("Assigned jobs");
            twAppointments.Nodes.Add("Unassigned jobs");

            foreach (Appointments app in applist)
            {
                if (app.TechAssigned != "None")
                {
                    twAppointments.Nodes[0].Nodes.Add(app.AppID + "| " + app.DateOApp.ToString() + " | " + app.TypeOApp + " | " + app.CompStatus + " | " + app.TechAssigned);
                }
                else
                {
                    twAppointments.Nodes[1].Nodes.Add(app.AppID + "| " + app.DateOApp.ToString() + " | " + app.TypeOApp + " | " + app.CompStatus);
                }
            }
        }

        private void btncallLogs_Click(object sender, EventArgs e)
        {
            Call_Logs C_L = new Call_Logs();
            C_L.Show();
            this.Close();
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void btncall_Click_1(object sender, EventArgs e)
        {
            start = DateTime.Now;
            Clients client = (Clients)dgvClients.CurrentRow.DataBoundItem;
            lblCallInProgress.Text = client.Name;

        }

        private void btnEndCall_Click_1(object sender, EventArgs e)
        {
            Clients clientselection = (Clients)dgvClients.CurrentRow.DataBoundItem;
            DateTime end = DateTime.Now;
            string duration = (end - start).ToString();
            CL.Insert(clientselection.ID, start, end, duration,cmbTechnicianAssigned.SelectedItem.ToString());
        }

        private void btnInsertAppointment_Click(object sender, EventArgs e)
        {
            if (dtpDOA.Text == "" || Convert.ToDateTime(dtpDOA.Text) < DateTime.Now)
            {
                MessageBox.Show("Please choose an appropriate date");
                dtpDOA.Focus();
            }
            else if (cmbTOA.Text == "" )
            {
                MessageBox.Show("Please choose type of appointment");
                cmbTOA.Focus();
            }
            else if (cmbCompletedStatus.Text == "")
            {
                MessageBox.Show("Please choose if task was completed or not");
                cmbCompletedStatus.Focus();
            }
            else if (cmbTechnicianAssigned.Text == "")
            {
                MessageBox.Show("Please choose Technician you wish to assign");
                cmbTechnicianAssigned.Focus();
            }
            
            {
                appointment.Insertapp(Convert.ToDateTime(dtpDOA.Text), cmbTOA.SelectedItem.ToString(), cmbCompletedStatus.SelectedItem.ToString(), cmbTechnicianAssigned.SelectedItem.ToString());
            }
            refresh();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            string selectedNodeText = twAppointments.SelectedNode.Text;
            string[] array = selectedNodeText.Split('|');
            
            if (Convert.ToDateTime(dtpDOA.Text) < DateTime.Now)
            {
                MessageBox.Show("Please enter duration of job");
                dtpDOA.Focus();
            }
            else
            {
                appointment.Update(array[0], "DateOApp", Convert.ToString(dtpDOA.Text));
            }
            if (cmbTOA.Text == "")
            {
                MessageBox.Show("Please choose type of appointment");
                cmbTOA.Focus();
            }
            else
            {
                appointment.Update(array[0], "TypeOApp", cmbTOA.SelectedItem.ToString());
            }
            if (cmbCompletedStatus.Text == "")
            {
                MessageBox.Show("Please choose if task was completed or not");
                cmbTOA.Focus();
            }
            else
            {
                appointment.Update(array[0], "CompStatus", cmbCompletedStatus.SelectedItem.ToString());
            }
            if (cmbTechnicianAssigned.Text == "")
            {
                MessageBox.Show("Please choose Technician you wish to assign");
                cmbTechnicianAssigned.Focus();
            }
            else
            {
                appointment.Update(array[0], "TechAssigned", cmbTechnicianAssigned.SelectedItem.ToString());
            }
            refresh();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            string selectedNodeText = twAppointments.SelectedNode.Text;
            string[] array = selectedNodeText.Split('|');
            appointment.Delete(int.Parse(array[0]));
            refresh();
        }

        private void twAppointments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedNodeText = e.Node.Text;
            string[] array = selectedNodeText.Split('|');
            for (int i = 0; i < array.Length; i++)
            {

            }
        }
    }
}
