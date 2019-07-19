namespace Municipal_management
{
    partial class Log_in
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.L1 = new System.Windows.Forms.Label();
            this.pswdTextbox = new System.Windows.Forms.TextBox();
            this.L2 = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(157, 49);
            this.userNameTextBox.Multiline = true;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(128, 28);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(40, 52);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(101, 25);
            this.L1.TabIndex = 1;
            this.L1.Text = "User Name";
            // 
            // pswdTextbox
            // 
            this.pswdTextbox.Location = new System.Drawing.Point(157, 111);
            this.pswdTextbox.Multiline = true;
            this.pswdTextbox.Name = "pswdTextbox";
            this.pswdTextbox.PasswordChar = '*';
            this.pswdTextbox.Size = new System.Drawing.Size(128, 27);
            this.pswdTextbox.TabIndex = 2;
            this.pswdTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L2.Location = new System.Drawing.Point(40, 110);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(88, 28);
            this.L2.TabIndex = 3;
            this.L2.Text = "Password";
            // 
            // logIn
            // 
            this.logIn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn.Location = new System.Drawing.Point(157, 188);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(81, 28);
            this.logIn.TabIndex = 4;
            this.logIn.Text = "Log In";
            this.logIn.UseVisualStyleBackColor = true;
            this.logIn.Click += new System.EventHandler(this.logIn_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(264, 188);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 24);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(500, 298);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.pswdTextbox);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "Log_in";
            this.Text = "User Log In";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginCLosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.TextBox pswdTextbox;
        private System.Windows.Forms.Label L2;
        private System.Windows.Forms.Button logIn;
        private System.Windows.Forms.Button cancel;

        
    }
}