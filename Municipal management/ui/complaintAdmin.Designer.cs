namespace Municipal_management.ui
{
    partial class complaintAdmin
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
            this.adminBtn = new System.Windows.Forms.Button();
            this.bsBtn = new System.Windows.Forms.Button();
            this.rgtnBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(16, 9);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(123, 42);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Administrator";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // bsBtn
            // 
            this.bsBtn.Location = new System.Drawing.Point(176, 9);
            this.bsBtn.Name = "bsBtn";
            this.bsBtn.Size = new System.Drawing.Size(119, 42);
            this.bsBtn.TabIndex = 1;
            this.bsBtn.Text = "Provide Voter Id No";
            this.bsBtn.UseVisualStyleBackColor = true;
            this.bsBtn.Click += new System.EventHandler(this.bsBtn_Click);
            // 
            // rgtnBtn
            // 
            this.rgtnBtn.Location = new System.Drawing.Point(335, 9);
            this.rgtnBtn.Name = "rgtnBtn";
            this.rgtnBtn.Size = new System.Drawing.Size(114, 42);
            this.rgtnBtn.TabIndex = 2;
            this.rgtnBtn.Text = "Provide Registration No";
            this.rgtnBtn.UseVisualStyleBackColor = true;
            this.rgtnBtn.Click += new System.EventHandler(this.rgtnBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.rgtnBtn);
            this.panel1.Controls.Add(this.bsBtn);
            this.panel1.Location = new System.Drawing.Point(91, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 74);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get the complaints";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(534, 297);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 15;
            this.button6.Text = "Go Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // complaintAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(705, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "complaintAdmin";
            this.Text = "Complain(Admin)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.complaintAdmin_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button bsBtn;
        private System.Windows.Forms.Button rgtnBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}