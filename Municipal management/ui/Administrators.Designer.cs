namespace Municipal_management
{
    partial class Administrators
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.serialNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.rgtrnBtn = new System.Windows.Forms.Button();
            this.Bsbtn = new System.Windows.Forms.Button();
            this.cmplnbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.votetxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SNBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(596, 339);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(83, 40);
            this.logOutButton.TabIndex = 20;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(160, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(270, 171);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.Location = new System.Drawing.Point(181, 42);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Size = new System.Drawing.Size(157, 23);
            this.appointmentBtn.TabIndex = 22;
            this.appointmentBtn.Text = "Get the Appointment Request";
            this.appointmentBtn.UseVisualStyleBackColor = true;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // serialNo
            // 
            this.serialNo.Location = new System.Drawing.Point(492, 246);
            this.serialNo.Name = "serialNo";
            this.serialNo.Size = new System.Drawing.Size(157, 23);
            this.serialNo.TabIndex = 23;
            this.serialNo.Text = "Insert serialNo";
            this.serialNo.UseVisualStyleBackColor = true;
            this.serialNo.Click += new System.EventHandler(this.serialNo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rgtrnBtn);
            this.panel1.Controls.Add(this.Bsbtn);
            this.panel1.Controls.Add(this.cmplnbtn);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 373);
            this.panel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "Provide Bills";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rgtrnBtn
            // 
            this.rgtrnBtn.Location = new System.Drawing.Point(22, 114);
            this.rgtrnBtn.Name = "rgtrnBtn";
            this.rgtrnBtn.Size = new System.Drawing.Size(100, 54);
            this.rgtrnBtn.TabIndex = 2;
            this.rgtrnBtn.Text = "Provide Registration No";
            this.rgtrnBtn.UseVisualStyleBackColor = true;
            this.rgtrnBtn.Click += new System.EventHandler(this.rgtrnBtn_Click);
            // 
            // Bsbtn
            // 
            this.Bsbtn.Location = new System.Drawing.Point(22, 204);
            this.Bsbtn.Name = "Bsbtn";
            this.Bsbtn.Size = new System.Drawing.Size(100, 43);
            this.Bsbtn.TabIndex = 1;
            this.Bsbtn.Text = "Provide Voter Id No";
            this.Bsbtn.UseVisualStyleBackColor = true;
            this.Bsbtn.Click += new System.EventHandler(this.Bsbtn_Click);
            // 
            // cmplnbtn
            // 
            this.cmplnbtn.Location = new System.Drawing.Point(22, 36);
            this.cmplnbtn.Name = "cmplnbtn";
            this.cmplnbtn.Size = new System.Drawing.Size(100, 57);
            this.cmplnbtn.TabIndex = 0;
            this.cmplnbtn.Text = "Go to the complaints section";
            this.cmplnbtn.UseVisualStyleBackColor = true;
            this.cmplnbtn.Click += new System.EventHandler(this.cmplnbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id No";
            // 
            // votetxtbox
            // 
            this.votetxtbox.Location = new System.Drawing.Point(549, 117);
            this.votetxtbox.Name = "votetxtbox";
            this.votetxtbox.Size = new System.Drawing.Size(100, 20);
            this.votetxtbox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Appointment date";
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(549, 158);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(100, 20);
            this.adBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "serial No";
            // 
            // SNBox
            // 
            this.SNBox.Location = new System.Drawing.Point(549, 203);
            this.SNBox.Name = "SNBox";
            this.SNBox.Size = new System.Drawing.Size(100, 20);
            this.SNBox.TabIndex = 35;
            // 
            // Administrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(691, 415);
            this.Controls.Add(this.SNBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.votetxtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.serialNo);
            this.Controls.Add(this.appointmentBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logOutButton);
            this.Name = "Administrators";
            this.Text = "Administrators Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrators_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button serialNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rgtrnBtn;
        private System.Windows.Forms.Button Bsbtn;
        private System.Windows.Forms.Button cmplnbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox votetxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SNBox;
    }
}