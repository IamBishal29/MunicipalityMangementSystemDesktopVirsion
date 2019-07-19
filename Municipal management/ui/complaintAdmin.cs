using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Municipal_management.ui;
using Municipal_management.BLL;

namespace Municipal_management.ui
{
    public partial class complaintAdmin : Form
    {
        public complaintAdmin()
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
            bsNoAdmin b = new bsNoAdmin();
            b.Show();
        }

        private void rgtnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VIAdmin r = new VIAdmin();
            r.Show();
        }

        private void complaintAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators ad = new Administrators();
            ad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Complain c = new Complain();
            dataGridView1.DataSource = c.getCmplnGrid();
        }
    }
}
