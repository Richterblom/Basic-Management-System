namespace Richter_Blom_SEN_Project
{
    partial class Contract_Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract_Creation));
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnNextDept = new System.Windows.Forms.Button();
            this.btnToContractManagment = new System.Windows.Forms.Button();
            this.btnConfirmContract = new System.Windows.Forms.Button();
            this.cbSeviceLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContractDur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(70, 7);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(340, 233);
            this.dgvClient.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(514, 7);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(340, 233);
            this.dgvProduct.TabIndex = 0;
            // 
            // btnNextDept
            // 
            this.btnNextDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDept.Location = new System.Drawing.Point(601, 405);
            this.btnNextDept.Name = "btnNextDept";
            this.btnNextDept.Size = new System.Drawing.Size(169, 31);
            this.btnNextDept.TabIndex = 96;
            this.btnNextDept.Text = "Menu";
            this.btnNextDept.UseVisualStyleBackColor = true;
            this.btnNextDept.Click += new System.EventHandler(this.btnNextDept_Click);
            // 
            // btnToContractManagment
            // 
            this.btnToContractManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToContractManagment.Location = new System.Drawing.Point(405, 405);
            this.btnToContractManagment.Name = "btnToContractManagment";
            this.btnToContractManagment.Size = new System.Drawing.Size(169, 31);
            this.btnToContractManagment.TabIndex = 94;
            this.btnToContractManagment.Text = "Contract Managment";
            this.btnToContractManagment.UseVisualStyleBackColor = true;
            // 
            // btnConfirmContract
            // 
            this.btnConfirmContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmContract.Location = new System.Drawing.Point(214, 405);
            this.btnConfirmContract.Name = "btnConfirmContract";
            this.btnConfirmContract.Size = new System.Drawing.Size(169, 31);
            this.btnConfirmContract.TabIndex = 93;
            this.btnConfirmContract.Text = "Confirm Contract Changes";
            this.btnConfirmContract.UseVisualStyleBackColor = true;
            this.btnConfirmContract.Click += new System.EventHandler(this.btnConfirmContract_Click);
            // 
            // cbSeviceLevel
            // 
            this.cbSeviceLevel.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cbSeviceLevel.FormattingEnabled = true;
            this.cbSeviceLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbSeviceLevel.Location = new System.Drawing.Point(483, 321);
            this.cbSeviceLevel.Name = "cbSeviceLevel";
            this.cbSeviceLevel.Size = new System.Drawing.Size(100, 21);
            this.cbSeviceLevel.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(355, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Service Level :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(356, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "Contract Durantion :";
            // 
            // txtContractDur
            // 
            this.txtContractDur.Location = new System.Drawing.Point(483, 282);
            this.txtContractDur.Name = "txtContractDur";
            this.txtContractDur.Size = new System.Drawing.Size(100, 20);
            this.txtContractDur.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(355, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Contract Type :";
            // 
            // cbContractType
            // 
            this.cbContractType.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cbContractType.FormattingEnabled = true;
            this.cbContractType.Items.AddRange(new object[] {
            "Installation",
            "Maintenance",
            "Upgrade",
            "Repair"});
            this.cbContractType.Location = new System.Drawing.Point(483, 359);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(100, 21);
            this.cbContractType.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(598, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Months";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(890, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // Contract_Creation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContractDur);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.cbSeviceLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNextDept);
            this.Controls.Add(this.btnToContractManagment);
            this.Controls.Add(this.btnConfirmContract);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.dgvClient);
            this.Name = "Contract_Creation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract_Creation";
            this.Load += new System.EventHandler(this.Contract_Creation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnNextDept;
        private System.Windows.Forms.Button btnToContractManagment;
        private System.Windows.Forms.Button btnConfirmContract;
        private System.Windows.Forms.ComboBox cbSeviceLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContractDur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}