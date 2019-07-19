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

namespace Municipal_management
{
    public partial class current_bills : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Bills.mdf;Integrated Security=True;Connect Timeout=30");
        public current_bills()
        {
            InitializeComponent();
        }

        private void voterIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_Id v = new Voter_Id();
            v.Show();
        }

        private void birthCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Birth_Certificate b = new Birth_Certificate();
            b.Show();
        }

        private void waterBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            water_bills wb = new water_bills();
            wb.Show();
        }

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaints cm = new complaints();
            cm.Show();
        }

        private void howToAddOrWriteCertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            help_abt_certificates hb = new help_abt_certificates();
            hb.Show();
        }

        private void settingUpAppopinmentWithTheOfficersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment_with_administrator aa = new appointment_with_administrator();
            aa.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome wc = new welcome();
            wc.Show();
        }

        private void ccButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Current_bill_calculator cbc = new Current_bill_calculator();
            //cbc.Show();
        }

        private void gasBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           gas_bills gb = new gas_bills();
            gb.Show();
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        private void CBClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void gyButton_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("select Electricitybill from Bill where Idno='"+voteridBox.Text+"'",con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                textBox1.Text = rd.GetValue(0).ToString();
            }
            con.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*con.Open();

            SqlCommand cmd = con.CreateCommand();
            // SqlDataReader read = (null);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Bill where Idno='" + voteridBox + "'";
            //read = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBox1.Text = (read["Electricitybill"].ToString());
                }
            }

            con.Close();*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
