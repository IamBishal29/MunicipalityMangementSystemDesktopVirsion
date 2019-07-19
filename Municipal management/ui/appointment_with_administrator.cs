using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Municipal_management.DAL;
using Municipal_management.BLL;

namespace Municipal_management
{
    public partial class appointment_with_administrator : Form
    {
        public appointment_with_administrator()
        {
            InitializeComponent();
        }

        private void voterIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_Id v = new Voter_Id();
            v.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome wel = new welcome();
            wel.Show();
        }

        private void birthCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Birth_Certificate b = new Birth_Certificate();
            b.Show();
        }

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)//complaint button
        {
            this.Hide();
            complaints cm = new complaints();
            cm.Show();
        }

        private void waterBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            water_bills wb = new water_bills();
            wb.Show();
        }

        private void currentBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            current_bills cb = new current_bills();
            cb.Show();
        }

        private void gasBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            gas_bills gb = new gas_bills();
            gb.Show();
        }

        private void howToAddOrWriteCertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            help_abt_certificates hac = new help_abt_certificates();
            hac.Show();
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        private void AppointmentForrmClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            appointment_administrator ab = new appointment_administrator();
            ab.IdNo = voteridBox.Text;
            ab.AppointmentDate = dateTimePicker1.Text;
            int rows = ab.getA(ab);
            if (rows > 0)
            {
                MessageBox.Show("Submitted..Wait for your Serial No");

            }
            else
            {
                MessageBox.Show("Error!!!");
            }

        }

        private void serialNoButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select serialNo from Appointment where IdNo = '" + voteridBox.Text + "'", cn);
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                serialnoBox.Text = rd.GetValue(0).ToString();
            }
            cn.Close();
        }
        
    }
}
