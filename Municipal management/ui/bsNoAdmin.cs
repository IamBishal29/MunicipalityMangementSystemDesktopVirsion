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
    public partial class bsNoAdmin : Form
    {
        public bsNoAdmin()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators a = new Administrators();
            a.Show();
        }

        private void bsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIAdmin v = new VIAdmin();
            v.Show();
        }

        private void cmplnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintAdmin c = new complaintAdmin();
            c.Show();
        }

        private void bsNoAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BcBtn_Click(object sender, EventArgs e)
        {
            BirthC b = new BirthC();

            birthGridView.DataSource = b.getdata();
        }

        private void birthGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.birthGridView.Rows[e.RowIndex];
            doiBox.Text = row.Cells[0].Value.ToString();
            nameBox.Text = row.Cells[1].Value.ToString();
        }

        private void rgstrnNo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Birth_Certificate.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update BS set RegistrationNo ='" + voteridNoBox.Text + "'  where Name = '" + nameBox.Text + "'", con);
            try
            {

                birthGridView.DataSource = cmd.ExecuteNonQuery();
            }
            catch
            {
                con.Close();
                throw;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators ad = new Administrators();
            ad.Show();

        }

    }
}
