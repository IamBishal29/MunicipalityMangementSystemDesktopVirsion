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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void birthCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void certificatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billsAndMisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void developmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void Info_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in log = new Log_in();
            log.Show();
        }

        private void birthCertificateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Birth_Certificate bs = new Birth_Certificate();
            bs.Show();
        }

        private void voterIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_Id vi = new Voter_Id();
            vi.Show();
        }

        private void setupAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            complaints com = new complaints();
            com.Show();
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
            help_abt_certificates hbc = new help_abt_certificates();
            hbc.Show();
        }

        private void settingUpAppopinmentWithTheOfficersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            appointment_with_administrator aa = new appointment_with_administrator();
            aa.Show();
        }

        private void welcomeClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




       

        

        
        
    }
}
