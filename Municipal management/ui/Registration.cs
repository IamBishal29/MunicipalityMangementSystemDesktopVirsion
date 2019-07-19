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
    public partial class Registration : Form
    {
        Log_in log = new Log_in();
        signing s = new signing();
        //Connection cn = new Connection();
        
        string Gender;
        public Registration()
        {
            InitializeComponent();
        }


        private void signUp_Click(object sender, EventArgs e)
        {
            s.firstName = textBox1.Text;
            s.lastName = textBox2.Text;
            s.userName = textBox3.Text;
            s.password = textBox4.Text;
            s.confirmPassword = cpBox.Text;
            s.mobileNo = textBox6.Text;
            s.dob = dateTimePicker1.Text;

            if (male.Checked == true)
            {
                Gender = "Male";   
            }
            else if (female.Checked == true)
            {
                Gender = "Female";
            }
            s.gender = Gender;

            Connection cn = new Connection();

            int rows = cn.insert(s);
            if (rows > 0)
            {
                MessageBox.Show("Added");
            }
            else 
            {
                MessageBox.Show("error");
            }

            this.Hide();
            log.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            administratorLogin admin = new administratorLogin();
            admin.Show();
        }

        private void regClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
