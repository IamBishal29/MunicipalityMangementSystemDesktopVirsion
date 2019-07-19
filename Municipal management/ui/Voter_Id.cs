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
using System.Data.SqlClient;

namespace Municipal_management
{
    public partial class Voter_Id : Form
    {
        string Gender;
        DataTable t = new DataTable();
        VoterId B = new VoterId();
         public Voter_Id()
        {
            InitializeComponent();
            t.Columns.Add(B.dateofIssue);
            t.Columns.Add(B.Name);
            t.Columns.Add(B.fathersName);
            t.Columns.Add(B.mothersName);
            t.Columns.Add(B.dob);
            t.Columns.Add(B.permanentAddress);
            t.Columns.Add(B.presentAddress);
            t.Columns.Add(B.nationality);
            t.Columns.Add(B.VotingArea);
            t.Columns.Add(B.gender);
            t.Columns.Add(B.IdNo);
        }
        //public Voter_Id()
        //{
           // InitializeComponent();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void birthCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Birth_Certificate bc = new Birth_Certificate();
            bc.Show();
        }

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
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
            help_abt_certificates hc = new help_abt_certificates();
            hc.Show();
        }

        private void settingUpAppopinmentWithTheOfficersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment_with_administrator aa = new appointment_with_administrator();
            aa.Show();
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        private void gohomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome wc = new welcome();
            wc.Show();
        }

        private void voterIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            VoterId br = new VoterId();
            br.dateofIssue = dateTimePicker1.Text;
            br.Name = nametextBox.Text;
            br.fathersName = FNBox.Text;
            br.mothersName = MnBox.Text;
            br.dob = dateTimePicker2.Text;
            br.permanentAddress =pAddressBox.Text;
            br.presentAddress = presentaddressBox.Text;
            br.nationality = nationalityBox.Text;
            br.VotingArea = votingareaBox.Text;
            if (MButton.Checked == true)
            {
                Gender = "Male";
            }
            else if (fmlButton.Checked == true)
            {
                Gender = "Female";
            }
            br.gender = Gender;
            int rows = br.getVi(br);
            if (rows > 0)
            {
                MessageBox.Show("Submitted..Wait for your Registration No");

            }
            else
            {
                MessageBox.Show("Error!!!");
            }
            br.IdNo = voteridnoBox.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select IdNo from VI where Name = '" + nametextBox.Text + "'", cn);
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                voteridnoBox.Text = rd.GetValue(0).ToString();
            }
            cn.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            // String s = string.Format();
            SqlCommand sql = new SqlCommand("select * from VI where Name ='" + nametextBox.Text + "'", con);
            SqlDataReader t = sql.ExecuteReader();
            t.Read();
            dateTimePicker1.Text = t.GetString(0);
            FNBox.Text = t.GetString(2);
            MnBox.Text = t.GetString(3);
            dateTimePicker2.Text = t.GetString(4);
            pAddressBox.Text= t.GetString(5);
            nationalityBox.Text =t.GetString(6);
            votingareaBox.Text= t.GetString(7);
            MButton.Text = t.GetString(8);
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("update VI set Dateofissue = '" + dateTimePicker1.Value + "',Name = '" + nametextBox.Text + "',FathersName='" + FNBox.Text + "',MothersName ='" + MnBox.Text + "', DOB='" + dateTimePicker2.Value + "',PermanentAddress = '" + pAddressBox.Text + "',Nationality = '" + nationalityBox.Text + "' where Name = '" + nametextBox.Text + "'", con);
            try
            {

                cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                throw;
            }
        }




    }
}
