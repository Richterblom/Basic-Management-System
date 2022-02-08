namespace Richter_Blom_SEN_Project
{
    partial class Call_Centre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Call_Centre));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.btncall = new System.Windows.Forms.Button();
            this.lblEndCall = new System.Windows.Forms.Label();
            this.lblInitiateCall = new System.Windows.Forms.Label();
            this.lblCallInProgress = new System.Windows.Forms.Label();
            this.lblCallStatus = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.btnInsertAppointment = new System.Windows.Forms.Button();
            this.dtpDOA = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btncallLogs = new System.Windows.Forms.Button();
            this.cmbTOA = new System.Windows.Forms.ComboBox();
            this.cmbCompletedStatus = new System.Windows.Forms.ComboBox();
            this.cmbTechnicianAssigned = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.twAppointments = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(813, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // btnEndCall
            // 
            this.btnEndCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndCall.BackgroundImage")));
            this.btnEndCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCall.Location = new System.Drawing.Point(579, 363);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(78, 56);
            this.btnEndCall.TabIndex = 10;
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click_1);
            // 
            // btncall
            // 
            this.btncall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncall.BackgroundImage")));
            this.btncall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncall.Location = new System.Drawing.Point(421, 363);
            this.btncall.Name = "btncall";
            this.btncall.Size = new System.Drawing.Size(78, 56);
            this.btncall.TabIndex = 9;
            this.btncall.UseVisualStyleBackColor = true;
            this.btncall.Click += new System.EventHandler(this.btncall_Click_1);
            // 
            // lblEndCall
            // 
            this.lblEndCall.AutoSize = true;
            this.lblEndCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndCall.Location = new System.Drawing.Point(576, 345);
            this.lblEndCall.Name = "lblEndCall";
            this.lblEndCall.Size = new System.Drawing.Size(61, 15);
            this.lblEndCall.TabIndex = 111;
            this.lblEndCall.Text = "End Call";
            // 
            // lblInitiateCall
            // 
            this.lblInitiateCall.AutoSize = true;
            this.lblInitiateCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitiateCall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInitiateCall.Location = new System.Drawing.Point(418, 345);
            this.lblInitiateCall.Name = "lblInitiateCall";
            this.lblInitiateCall.Size = new System.Drawing.Size(80, 15);
            this.lblInitiateCall.TabIndex = 110;
            this.lblInitiateCall.Text = "Initiate Call";
            // 
            // lblCallInProgress
            // 
            this.lblCallInProgress.AutoSize = true;
            this.lblCallInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallInProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCallInProgress.Location = new System.Drawing.Point(526, 436);
            this.lblCallInProgress.Name = "lblCallInProgress";
            this.lblCallInProgress.Size = new System.Drawing.Size(150, 15);
            this.lblCallInProgress.TabIndex = 109;
            this.lblCallInProgress.Text = "No Calls In Progress...";
            // 
            // lblCallStatus
            // 
            this.lblCallStatus.AutoSize = true;
            this.lblCallStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCallStatus.Location = new System.Drawing.Point(420, 436);
            this.lblCallStatus.Name = "lblCallStatus";
            this.lblCallStatus.Size = new System.Drawing.Size(84, 15);
            this.lblCallStatus.TabIndex = 108;
            this.lblCallStatus.Text = "Call Status: ";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(694, 466);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(113, 62);
            this.btnDeleteAppointment.TabIndex = 13;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.Location = new System.Drawing.Point(571, 466);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(117, 62);
            this.btnUpdateAppointment.TabIndex = 12;
            this.btnUpdateAppointment.Text = "Update Appointment";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // btnInsertAppointment
            // 
            this.btnInsertAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertAppointment.Location = new System.Drawing.Point(436, 466);
            this.btnInsertAppointment.Name = "btnInsertAppointment";
            this.btnInsertAppointment.Size = new System.Drawing.Size(129, 62);
            this.btnInsertAppointment.TabIndex = 11;
            this.btnInsertAppointment.Text = "Insert Appointment";
            this.btnInsertAppointment.UseVisualStyleBackColor = true;
            this.btnInsertAppointment.Click += new System.EventHandler(this.btnInsertAppointment_Click);
            // 
            // dtpDOA
            // 
            this.dtpDOA.CustomFormat = "";
            this.dtpDOA.Location = new System.Drawing.Point(579, 53);
            this.dtpDOA.Name = "dtpDOA";
            this.dtpDOA.Size = new System.Drawing.Size(194, 20);
            this.dtpDOA.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(404, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 15);
            this.label11.TabIndex = 100;
            this.label11.Text = "Technician Assigned:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(404, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 93;
            this.label3.Text = "Completed Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(404, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 92;
            this.label4.Text = "Type Of Appointment:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(404, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Date Of Appointment:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(157, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 115;
            this.label1.Text = "Appointments";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(407, 180);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(436, 150);
            this.dgvClients.TabIndex = 116;
            // 
            // btncallLogs
            // 
            this.btncallLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncallLogs.Location = new System.Drawing.Point(714, 363);
            this.btncallLogs.Name = "btncallLogs";
            this.btncallLogs.Size = new System.Drawing.Size(129, 33);
            this.btncallLogs.TabIndex = 117;
            this.btncallLogs.Text = "Caller Logs";
            this.btncallLogs.UseVisualStyleBackColor = true;
            this.btncallLogs.Click += new System.EventHandler(this.btncallLogs_Click);
            // 
            // cmbTOA
            // 
            this.cmbTOA.FormattingEnabled = true;
            this.cmbTOA.Items.AddRange(new object[] {
            "Installation",
            "Maintenance",
            "Upgrade",
            "Repair"});
            this.cmbTOA.Location = new System.Drawing.Point(579, 79);
            this.cmbTOA.Name = "cmbTOA";
            this.cmbTOA.Size = new System.Drawing.Size(194, 21);
            this.cmbTOA.TabIndex = 118;
            // 
            // cmbCompletedStatus
            // 
            this.cmbCompletedStatus.FormattingEnabled = true;
            this.cmbCompletedStatus.Items.AddRange(new object[] {
            "Complete",
            "Incomplete"});
            this.cmbCompletedStatus.Location = new System.Drawing.Point(579, 111);
            this.cmbCompletedStatus.Name = "cmbCompletedStatus";
            this.cmbCompletedStatus.Size = new System.Drawing.Size(194, 21);
            this.cmbCompletedStatus.TabIndex = 118;
            // 
            // cmbTechnicianAssigned
            // 
            this.cmbTechnicianAssigned.FormattingEnabled = true;
            this.cmbTechnicianAssigned.Location = new System.Drawing.Point(579, 144);
            this.cmbTechnicianAssigned.Name = "cmbTechnicianAssigned";
            this.cmbTechnicianAssigned.Size = new System.Drawing.Size(194, 21);
            this.cmbTechnicianAssigned.TabIndex = 118;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(714, 403);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(129, 33);
            this.btnMenu.TabIndex = 120;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // twAppointments
            // 
            this.twAppointments.Location = new System.Drawing.Point(12, 25);
            this.twAppointments.Name = "twAppointments";
            this.twAppointments.Size = new System.Drawing.Size(386, 503);
            this.twAppointments.TabIndex = 121;
            this.twAppointments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twAppointments_AfterSelect);
            // 
            // Call_Centre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(855, 555);
            this.Controls.Add(this.twAppointments);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cmbTechnicianAssigned);
            this.Controls.Add(this.cmbCompletedStatus);
            this.Controls.Add(this.cmbTOA);
            this.Controls.Add(this.btncallLogs);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEndCall);
            this.Controls.Add(this.btncall);
            this.Controls.Add(this.lblEndCall);
            this.Controls.Add(this.lblInitiateCall);
            this.Controls.Add(this.lblCallInProgress);
            this.Controls.Add(this.lblCallStatus);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.btnInsertAppointment);
            this.Controls.Add(this.dtpDOA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Call_Centre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call_Centre";
            this.Load += new System.EventHandler(this.Call_Centre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Button btncall;
        private System.Windows.Forms.Label lblEndCall;
        private System.Windows.Forms.Label lblInitiateCall;
        private System.Windows.Forms.Label lblCallInProgress;
        private System.Windows.Forms.Label lblCallStatus;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnInsertAppointment;
        private System.Windows.Forms.DateTimePicker dtpDOA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btncallLogs;
        private System.Windows.Forms.ComboBox cmbTOA;
        private System.Windows.Forms.ComboBox cmbCompletedStatus;
        private System.Windows.Forms.ComboBox cmbTechnicianAssigned;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TreeView twAppointments;
    }
}