namespace Richter_Blom_SEN_Project
{
    partial class Contract_Managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contract_Managment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.btnNextDept = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobDur = new System.Windows.Forms.TextBox();
            this.cbContractType = new System.Windows.Forms.ComboBox();
            this.cbSeviceLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1007, 404);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(535, 364);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(115, 23);
            this.btnLast.TabIndex = 102;
            this.btnLast.Text = "Last Contract";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(335, 364);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(115, 23);
            this.btnFirst.TabIndex = 101;
            this.btnFirst.Text = "First Contract";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(166, 364);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(128, 23);
            this.btnPrev.TabIndex = 100;
            this.btnPrev.Text = "Previous Contract";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(6, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 23);
            this.btnNext.TabIndex = 103;
            this.btnNext.Text = "Next Contract";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Location = new System.Drawing.Point(6, 12);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.RowHeadersVisible = false;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(644, 315);
            this.dgvContract.TabIndex = 93;
            this.dgvContract.SelectionChanged += new System.EventHandler(this.dgvContract_SelectionChanged);
            // 
            // btnNextDept
            // 
            this.btnNextDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDept.Location = new System.Drawing.Point(760, 361);
            this.btnNextDept.Name = "btnNextDept";
            this.btnNextDept.Size = new System.Drawing.Size(169, 26);
            this.btnNextDept.TabIndex = 91;
            this.btnNextDept.Text = "Menu";
            this.btnNextDept.UseVisualStyleBackColor = true;
            this.btnNextDept.Click += new System.EventHandler(this.btnNextDept_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.Location = new System.Drawing.Point(844, 299);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(169, 31);
            this.btnDetails.TabIndex = 89;
            this.btnDetails.Text = "Update Contract";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(656, 299);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(169, 31);
            this.btnInsert.TabIndex = 88;
            this.btnInsert.Text = "Create Contract";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(824, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Update";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(774, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(197, 20);
            this.txtSearch.TabIndex = 104;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(711, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Search :";
            // 
            // txtJobDur
            // 
            this.txtJobDur.Location = new System.Drawing.Point(829, 120);
            this.txtJobDur.Name = "txtJobDur";
            this.txtJobDur.Size = new System.Drawing.Size(100, 20);
            this.txtJobDur.TabIndex = 119;
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
            this.cbContractType.Location = new System.Drawing.Point(829, 197);
            this.cbContractType.Name = "cbContractType";
            this.cbContractType.Size = new System.Drawing.Size(100, 21);
            this.cbContractType.TabIndex = 113;
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
            this.cbSeviceLevel.Location = new System.Drawing.Point(829, 159);
            this.cbSeviceLevel.Name = "cbSeviceLevel";
            this.cbSeviceLevel.Size = new System.Drawing.Size(100, 21);
            this.cbSeviceLevel.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(701, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 115;
            this.label3.Text = "Contract Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(701, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 116;
            this.label8.Text = "Service Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(944, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 117;
            this.label4.Text = "Months";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(702, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 118;
            this.label7.Text = "Job Durantion :";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Active",
            "Inactive"});
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.cbStatus.Location = new System.Drawing.Point(829, 241);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 21);
            this.cbStatus.TabIndex = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(701, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Status :";
            // 
            // Contract_Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1049, 435);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJobDur);
            this.Controls.Add(this.cbContractType);
            this.Controls.Add(this.cbSeviceLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dgvContract);
            this.Controls.Add(this.btnNextDept);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Name = "Contract_Managment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contract_Managment";
            this.Load += new System.EventHandler(this.Contract_Managment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.Button btnNextDept;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobDur;
        private System.Windows.Forms.ComboBox cbContractType;
        private System.Windows.Forms.ComboBox cbSeviceLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
    }
}