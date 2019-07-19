namespace Municipal_management.ui
{
    partial class bsNoAdmin
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
            this.cmplnBtn = new System.Windows.Forms.Button();
            this.bsBtn = new System.Windows.Forms.Button();
            this.birthGridView = new System.Windows.Forms.DataGridView();
            this.BcBtn = new System.Windows.Forms.Button();
            this.rgstrnNo = new System.Windows.Forms.Button();
            this.voteridNoBox = new System.Windows.Forms.TextBox();
            this.doiLabel = new System.Windows.Forms.Label();
            this.doiBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.cmplnBtn);
            this.panel1.Controls.Add(this.bsBtn);
            this.panel1.Location = new System.Drawing.Point(114, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 58);
            this.panel1.TabIndex = 4;
            // 
            // adminBtn
            // 
            this.adminBtn.Location = new System.Drawing.Point(28, 0);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(123, 42);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Administrator";
            this.adminBtn.UseVisualStyleBackColor = true;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // cmplnBtn
            // 
            this.cmplnBtn.Location = new System.Drawing.Point(366, 3);
            this.cmplnBtn.Name = "cmplnBtn";
            this.cmplnBtn.Size = new System.Drawing.Size(114, 42);
            this.cmplnBtn.TabIndex = 2;
            this.cmplnBtn.Text = "Complain";
            this.cmplnBtn.UseVisualStyleBackColor = true;
            this.cmplnBtn.Click += new System.EventHandler(this.cmplnBtn_Click);
            // 
            // bsBtn
            // 
            this.bsBtn.Location = new System.Drawing.Point(196, 0);
            this.bsBtn.Name = "bsBtn";
            this.bsBtn.Size = new System.Drawing.Size(119, 42);
            this.bsBtn.TabIndex = 1;
            this.bsBtn.Text = "Provide Voter Id No";
            this.bsBtn.UseVisualStyleBackColor = true;
            this.bsBtn.Click += new System.EventHandler(this.bsBtn_Click);
            // 
            // birthGridView
            // 
            this.birthGridView.AllowUserToAddRows = false;
            this.birthGridView.AllowUserToDeleteRows = false;
            this.birthGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.birthGridView.Location = new System.Drawing.Point(57, 128);
            this.birthGridView.Name = "birthGridView";
            this.birthGridView.ReadOnly = true;
            this.birthGridView.Size = new System.Drawing.Size(270, 171);
            this.birthGridView.TabIndex = 23;
            this.birthGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.birthGridView_CellContentClick);
            // 
            // BcBtn
            // 
            this.BcBtn.Location = new System.Drawing.Point(57, 89);
            this.BcBtn.Name = "BcBtn";
            this.BcBtn.Size = new System.Drawing.Size(166, 23);
            this.BcBtn.TabIndex = 24;
            this.BcBtn.Text = "Get the Birth Certificate Forms";
            this.BcBtn.UseVisualStyleBackColor = true;
            this.BcBtn.Click += new System.EventHandler(this.BcBtn_Click);
            // 
            // rgstrnNo
            // 
            this.rgstrnNo.Location = new System.Drawing.Point(383, 276);
            this.rgstrnNo.Name = "rgstrnNo";
            this.rgstrnNo.Size = new System.Drawing.Size(166, 23);
            this.rgstrnNo.TabIndex = 25;
            this.rgstrnNo.Text = "Insert Registratio No";
            this.rgstrnNo.UseVisualStyleBackColor = true;
            this.rgstrnNo.Click += new System.EventHandler(this.rgstrnNo_Click);
            // 
            // voteridNoBox
            // 
            this.voteridNoBox.Location = new System.Drawing.Point(409, 239);
            this.voteridNoBox.Name = "voteridNoBox";
            this.voteridNoBox.Size = new System.Drawing.Size(100, 20);
            this.voteridNoBox.TabIndex = 26;
            // 
            // doiLabel
            // 
            this.doiLabel.AutoSize = true;
            this.doiLabel.Location = new System.Drawing.Point(360, 130);
            this.doiLabel.Name = "doiLabel";
            this.doiLabel.Size = new System.Drawing.Size(69, 13);
            this.doiLabel.TabIndex = 30;
            this.doiLabel.Text = "Date of issue";
            // 
            // doiBox
            // 
            this.doiBox.Location = new System.Drawing.Point(470, 130);
            this.doiBox.Name = "doiBox";
            this.doiBox.Size = new System.Drawing.Size(100, 20);
            this.doiBox.TabIndex = 31;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(360, 167);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 32;
            this.Namelabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(470, 167);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 33;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(596, 271);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 34;
            this.button6.Text = "Go Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bsNoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(704, 376);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.doiBox);
            this.Controls.Add(this.doiLabel);
            this.Controls.Add(this.voteridNoBox);
            this.Controls.Add(this.rgstrnNo);
            this.Controls.Add(this.BcBtn);
            this.Controls.Add(this.birthGridView);
            this.Controls.Add(this.panel1);
            this.Name = "bsNoAdmin";
            this.Text = "Birth Certificate No.(Admin)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bsNoAdmin_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.birthGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button cmplnBtn;
        private System.Windows.Forms.Button bsBtn;
        private System.Windows.Forms.DataGridView birthGridView;
        private System.Windows.Forms.Button BcBtn;
        private System.Windows.Forms.Button rgstrnNo;
        private System.Windows.Forms.TextBox voteridNoBox;
        private System.Windows.Forms.Label doiLabel;
        private System.Windows.Forms.TextBox doiBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button6;
    }
}