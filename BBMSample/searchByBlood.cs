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
    public partial class searchByBlood : Form
    {
        function fn = new function();
        public searchByBlood()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchByBlood_Load(object sender, EventArgs e)
        {
            String query = "select * from newDonor";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void txtSearchBlood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBlood.Text != "")
            {
                String query = "select * from newDonor where bloodgroup Like '" + txtSearchBlood.Text + "%'          ";
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
    }
}
