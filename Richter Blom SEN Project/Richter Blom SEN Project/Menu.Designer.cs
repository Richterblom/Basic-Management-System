namespace Richter_Blom_SEN_Project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btncontrractmgmnet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(122, 95);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(169, 31);
            this.btnClient.TabIndex = 58;
            this.btnClient.Text = "Client Management";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(122, 147);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(169, 31);
            this.btnProduct.TabIndex = 59;
            this.btnProduct.Text = "Product Management";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(165, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 48);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.Location = new System.Drawing.Point(122, 254);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(169, 31);
            this.btnMaintenance.TabIndex = 60;
            this.btnMaintenance.Text = "Technicians ";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallCentre.Location = new System.Drawing.Point(122, 306);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(169, 31);
            this.btnCallCentre.TabIndex = 82;
            this.btnCallCentre.Text = "Call Centre";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // btncontrractmgmnet
            // 
            this.btncontrractmgmnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontrractmgmnet.Location = new System.Drawing.Point(122, 200);
            this.btncontrractmgmnet.Name = "btncontrractmgmnet";
            this.btncontrractmgmnet.Size = new System.Drawing.Size(169, 31);
            this.btncontrractmgmnet.TabIndex = 82;
            this.btncontrractmgmnet.Text = "Contract managment";
            this.btncontrractmgmnet.UseVisualStyleBackColor = true;
            this.btncontrractmgmnet.Click += new System.EventHandler(this.btncontrractmgmnet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(122, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 27);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(422, 405);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btncontrractmgmnet);
            this.Controls.Add(this.btnCallCentre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btncontrractmgmnet;
        private System.Windows.Forms.Button btnExit;
    }
}