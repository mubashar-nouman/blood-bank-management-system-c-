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
    public partial class searchByAdress : Form
    {
        function fn = new function();
        public searchByAdress()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchByAdress_Load(object sender, EventArgs e)
        {
            String query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtAdress_TextAlignChanged(object sender, EventArgs e)
        {
        }

        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtAdress.Text != "")
            {
                String query = "select * from newDonor where city Like '" + txtAdress.Text + "%' or dadress Like '" + txtAdress.Text + "%'          ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                String query = "select * from newDonor";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
   }
