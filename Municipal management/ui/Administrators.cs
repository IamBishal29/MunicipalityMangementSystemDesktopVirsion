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
using Municipal_management.BLL;
using Municipal_management.DAL;
using Municipal_management.ui;

namespace Municipal_management
{
    public partial class Administrators : Form
    {
        public Administrators()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            administratorLogin admin = new administratorLogin();
            admin.Show();
        }
        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            //Connection cn = new Connection();
            dataGridView1.DataSource = a.getdata();
        }

        private void cmplnbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaintAdmin ca = new complaintAdmin();
            ca.Show();
        }
        private void Administrators_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //int indexRow;

        private void serialNo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Bishal\Desktop\Municipal management\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Appointment set SerialNo ='" + SNBox.Text + "'  where IdNo = '" + votetxtbox.Text + "'", con);
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

        
        private void rgtrnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            bsNoAdmin r = new bsNoAdmin();
            r.Show();
        }
        private void Bsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIAdmin b = new VIAdmin();
            b.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InsertBills Bill = new InsertBills();
            Bill.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            votetxtbox.Text = row.Cells[0].Value.ToString();
            adBox.Text = row.Cells[1].Value.ToString();
        }




        

        
    }
}
