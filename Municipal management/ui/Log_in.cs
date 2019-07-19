using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Municipal_management.BLL;
using Municipal_management.DAL;

namespace Municipal_management
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f1 = new Registration();
            f1.Show();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            signing s = new signing();
            s.userName = userNameTextBox.Text;
            s.password = pswdTextbox.Text;
            Connection cn = new Connection();
            DataTable dt = new DataTable();
            dt = cn.Select(s);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                welcome wel = new welcome();
                wel.Show();
            }
            else 
            {
                MessageBox.Show("Invalid userName and Password");
            }
                    
        }

        private void loginCLosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
