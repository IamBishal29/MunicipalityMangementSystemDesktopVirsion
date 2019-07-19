namespace Municipal_management.ui
{
    partial class VIAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.rgtnBtn = new System.Windows.Forms.Button();
            this.cmplnBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voterBtn = new System.Windows.Forms.Button();
            this.insertVIBtn = new System.Windows.Forms.Button();
            this.voteridNoBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.doiBox = new System.Windows.Forms.TextBox();
            this.doiLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.rgtnBtn);
            this.panel1.Controls.Add(this.cmplnBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 77);
            this.panel1.TabIndex = 4;
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(28, 9);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(123, 42);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Administrator";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // rgtnBtn
            // 
            this.rgtnBtn.Location = new System.Drawing.Point(460, 9);
            this.rgtnBtn.Name = "rgtnBtn";
            this.rgtnBtn.Size = new System.Drawing.Size(114, 42);
            this.rgtnBtn.TabIndex = 2;
            this.rgtnBtn.Text = "Provide Registration No";
            this.rgtnBtn.UseVisualStyleBackColor = true;
            this.rgtnBtn.Click += new System.EventHandler(this.rgtnBtn_Click);
            // 
            // cmplnBtn
            // 
            this.cmplnBtn.Location = new System.Drawing.Point(254, 9);
            this.cmplnBtn.Name = "cmplnBtn";
            this.cmplnBtn.Size = new System.Drawing.Size(119, 42);
            this.cmplnBtn.TabIndex = 1;
            this.cmplnBtn.Text = "Complaint ";
            this.cmplnBtn.UseVisualStyleBackColor = true;
            this.cmplnBtn.Click += new System.EventHandler(this.cmplnBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 171);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // voterBtn
            // 
            this.voterBtn.Location = new System.Drawing.Point(31, 106);
            this.voterBtn.Name = "voterBtn";
            this.voterBtn.Size = new System.Drawing.Size(166, 23);
            this.voterBtn.TabIndex = 23;
            this.voterBtn.Text = "Get the Voter Forms";
            this.voterBtn.UseVisualStyleBackColor = true;
            this.voterBtn.Click += new System.EventHandler(this.voterBtn_Click);
            // 
            // insertVIBtn
            // 
            this.insertVIBtn.Location = new System.Drawing.Point(398, 283);
            this.insertVIBtn.Name = "insertVIBtn";
            this.insertVIBtn.Size = new System.Drawing.Size(123, 23);
            this.insertVIBtn.TabIndex = 24;
            this.insertVIBtn.Text = "Insert voter Id no";
            this.insertVIBtn.UseVisualStyleBackColor = true;
            this.insertVIBtn.Click += new System.EventHandler(this.insertVIBtn_Click);
            // 
            // voteridNoBox
            // 
            this.voteridNoBox.Location = new System.Drawing.Point(398, 257);
            this.voteridNoBox.Name = "voteridNoBox";
            this.voteridNoBox.Size = new System.Drawing.Size(100, 20);
            this.voteridNoBox.TabIndex = 25;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(540, 338);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 26;
            this.button6.Text = "Go Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // doiBox
            // 
            this.doiBox.Location = new System.Drawing.Point(398, 150);
            this.doiBox.Name = "doiBox";
            this.doiBox.Size = new System.Drawing.Size(100, 20);
            this.doiBox.TabIndex = 32;
            // 
            // doiLabel
            // 
            this.doiLabel.AutoSize = true;
            this.doiLabel.Location = new System.Drawing.Point(307, 153);
            this.doiLabel.Name = "doiLabel";
            this.doiLabel.Size = new System.Drawing.Size(69, 13);
            this.doiLabel.TabIndex = 33;
            this.doiLabel.Text = "Date of issue";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(341, 193);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 34;
            this.Namelabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(398, 193);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 35;
            // 
            // VIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(645, 423);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.doiLabel);
            this.Controls.Add(this.doiBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.voteridNoBox);
            this.Controls.Add(this.insertVIBtn);
            this.Controls.Add(this.voterBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "VIAdmin";
            this.Text = "Provide Voter ID";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VIAdmin_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button rgtnBtn;
        private System.Windows.Forms.Button cmplnBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button voterBtn;
        private System.Windows.Forms.Button insertVIBtn;
        private System.Windows.Forms.TextBox voteridNoBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox doiBox;
        private System.Windows.Forms.Label doiLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox nameBox;
    }
}