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
using System.Data.SqlClient;


namespace Municipal_management.ui
{
    public partial class VIAdmin : Form
    {
        public VIAdmin()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators a = new Administrators();
            a.Show();
        }

        private void cmplnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintAdmin c = new complaintAdmin();
            c.Show();
        }

        private void rgtnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bsNoAdmin b = new bsNoAdmin();
            b.Show();
        }

        private void VIAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators ad = new Administrators();
            ad.Show();
        }

        private void voterBtn_Click(object sender, EventArgs e)
        {
            VoterId b = new VoterId();

            dataGridView1.DataSource = b.getdata1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            doiBox.Text = row.Cells[0].Value.ToString();
            nameBox.Text = row.Cells[1].Value.ToString();
        }

        private void insertVIBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Voter_Id.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update VI set IdNo ='" + voteridNoBox.Text + "'  where Name = '" + nameBox.Text + "'", con);
            try
            {

                dataGridView1.DataSource = cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                throw;
            }
        }



    }
}
