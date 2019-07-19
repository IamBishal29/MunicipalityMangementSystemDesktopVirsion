using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Municipal_management.BLL;
using Municipal_management.DAL;

namespace Municipal_management
{
    public partial class Birth_Certificate : Form
    {
        string Gender;
        DataTable t = new DataTable();
        BirthC B = new BirthC();

        public Birth_Certificate()
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
            t.Columns.Add(B.gender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                browseBox.Text = ofd.FileName;
                browseBox.Text = ofd.SafeFileName;
                

            }*/
        }

        private void gohomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome w = new welcome();
            w.Show();
        }

        private void voterIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_Id v = new Voter_Id();
            v.Show();
        }

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaints c = new complaints();
            c.Show();
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
            appointment_with_administrator aa = new appointment_with_administrator();
            aa.Show();
        }

        private void settingUpAppopinmentWithTheOfficersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            help_abt_certificates hc = new help_abt_certificates();
            hc.Show();
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        

        private void submitButton_Click(object sender, EventArgs e)
        {
           
            
            BirthC br = new BirthC();
            br.dateofIssue = dateTimePicker1.Text;
            br.Name = nametextBox.Text;
            br.fathersName = fnBox.Text;
            br.mothersName = mnBox.Text;
            br.dob = dateTimePicker2.Text;
            br.permanentAddress = pAddressbox.Text;
            br.presentAddress = presentaddressBox.Text;
            br.nationality = nationalityBox.Text;
            
            //Connection cn = new Connection();
            
            
            
            if (MButton.Checked == true)
            {
                Gender = "Male";
            }
            else if (fmlButton.Checked == true)
            {
                Gender = "Female";
            }
            br.gender = Gender;
            int rows = br.getBs(br);
            if (rows > 0)
            {
                MessageBox.Show("Submitted..Wait for your Registration No");

            }
            else
            {
                MessageBox.Show("Error!!!");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
           
            //t.Rows.Clear();
            //srchGrid.DataSource = t;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            // String s = string.Format();
            SqlCommand sql = new SqlCommand("select * from BS where Name ='" + nametextBox.Text + "'", con);
            SqlDataReader t = sql.ExecuteReader();
            t.Read();
            dateTimePicker1.Text = t.GetString(0);
            fnBox.Text = t.GetString(2);
            mnBox.Text = t.GetString(3);
            dateTimePicker2.Text = t.GetString(4);
            pAddressbox.Text = t.GetString(5);
            presentaddressBox.Text = t.GetString(6);
            nationalityBox.Text = t.GetString(7);
            Gender = t.GetString(8);


        }

        private void BSclosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand cmd = new SqlCommand("update BS set Dateofissue = '" + dateTimePicker1.Value + "',Name = '" + nametextBox.Text + "',FathersName='" + fnBox.Text + "',MothersName ='" + mnBox.Text + "', DateofBirth='" + dateTimePicker2.Value + "',PermanentAddress = '" + pAddressbox.Text + "',PresentAddress='" + presentaddressBox.Text + "',Nationality = '" + nationalityBox.Text + "' where Name = '" + nametextBox.Text + "'", con);
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

        private void gyButton_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand("select RegistrationNo from BS where Name = '" + nametextBox.Text + "'", cn);
            cn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                regnoBox.Text = rd.GetValue(0).ToString();
            }
            cn.Close();
        }

       
    }
}
