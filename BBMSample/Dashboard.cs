using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMSample
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void updateDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDonorDetails udd = new updateDonorDetails();
            udd.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void addNewDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void allDonorsDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorsDetails add = new AllDonorsDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchByAdress sba = new searchByAdress();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchByBlood sd = new searchByBlood();
            sd.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockIncrease si = new stockIncrease();
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockDecrease sd = new stockDecrease();
        }
    }
}
