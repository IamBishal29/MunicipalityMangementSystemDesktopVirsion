using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Municipal_management
{
    public partial class help_abt_certificates : Form
    {
        public help_abt_certificates()
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
            Birth_Certificate bc = new Birth_Certificate();
            bc.Show();
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

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaints c = new complaints();
            c.Show();
        }

        private void howToAddOrWriteCertificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
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

        private void helpcertificateClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
