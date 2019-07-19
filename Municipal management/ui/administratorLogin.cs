using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Municipal_management.DAL;
using Municipal_management.BLL;

namespace Municipal_management
{
    public partial class administratorLogin : Form
    {
        public administratorLogin()
        {
            InitializeComponent();

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            AdminLog s = new AdminLog();
            s.UserName = userNameTextBox.Text;
            s.Password = pswdTextBox.Text;
            //Connection cn = new Connection();
            DataTable dt = new DataTable();
            dt = s.getAdminData(s);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Administrators admin = new Administrators();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid userName and Password");
            }

           
        }

        private void administratorLogin_Load(object sender, EventArgs e)
        {

        }

        private void AdministratorLoginFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
