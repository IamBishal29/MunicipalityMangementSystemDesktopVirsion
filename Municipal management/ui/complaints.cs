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

namespace Municipal_management
{
    public partial class complaints : Form
    {
        public complaints()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome wel = new welcome();
            wel.Show();
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

        private void currentBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            current_bills cb= new current_bills();
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
            appointment_with_administrator awa = new appointment_with_administrator();
            awa.Show();
        }

        private void calculateYourOwnCurrentBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            billHelp bh = new billHelp();
            bh.Show();
        }

        private void cmplntClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        string n;
        private void submitButton_Click(object sender, EventArgs e)
        {
            Complain cm = new Complain();
            cm.id = voteridBox.Text;
            cm.other = cmnTextbox.Text;
            
            if (elecBill.Checked == true)
            {
                n = "Current bill is too high!!";
            }
            else if(watbill.Checked== true)
            {
                n="Water bill is too high!!";
            }
            else if(gasBill.Checked==true)
            {
                n = "Gas bill is too high!!!";
            }
            cm.complain = n;
            int rows = cm.getCmpln(cm);
            if (rows > 0)
            {
                MessageBox.Show("Thank you for your response!!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


    }
}
