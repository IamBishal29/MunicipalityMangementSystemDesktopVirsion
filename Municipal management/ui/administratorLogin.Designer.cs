namespace Municipal_management
{
    partial class administratorLogin
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
            this.L1 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.pswdTextBox = new System.Windows.Forms.TextBox();
            this.logIn = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(87, 77);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(101, 25);
            this.L1.TabIndex = 2;
            this.L1.Text = "User Name";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(222, 74);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(128, 28);
            this.userNameTextBox.TabIndex = 3;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(100, 130);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(88, 28);
            this.L2.TabIndex = 4;
            this.L2.Text = "Password";
            // 
            // pswdTextBox
            // 
            this.pswdTextBox.Location = new System.Drawing.Point(222, 130);
            this.pswdTextBox.Multiline = true;
            this.pswdTextBox.Name = "pswdTextBox";
            this.pswdTextBox.PasswordChar = '*';
            this.pswdTextBox.Size = new System.Drawing.Size(128, 27);
            this.pswdTextBox.TabIndex = 5;
            // 
            // logIn
            // 
            this.logIn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(105, 210);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(81, 28);
            this.logIn.TabIndex = 6;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(269, 210);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Administrators";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // administratorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(526, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.pswdTextBox);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.L1);
            this.Name = "administratorLogin";
            this.Text = "Administrator Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorLoginFormClosing);
            this.Load += new System.EventHandler(this.administratorLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.TextBox pswdTextBox;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
    }
}