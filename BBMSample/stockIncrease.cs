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
    public partial class stockIncrease : Form
    {
        function fn = new function();
        public stockIncrease()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockIncrease_Load(object sender, EventArgs e)
        {
            String query = "select blood_group,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            String query = "update stock set quantity =quantity+" + txtUnits.Text + " where blood_group = '" + txtBloodGrop.Text + "'     ";
            fn.setData(query);
            stockIncrease_Load(this, null);
        }
    }
}
