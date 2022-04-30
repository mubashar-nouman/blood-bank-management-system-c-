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
    public partial class stockDecrease : Form
    {
        function fn = new function();
        public stockDecrease()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockDecrease_Load(object sender, EventArgs e)
        {
            String query = "select blood_group,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            String query = "update stock set quantity =quantity-" + txtUnits.Text + " where blood_group = '" + txtBloodGrop.Text + "'     ";
            fn.setData(query);
            stockDecrease_Load(this, null);
        }
    }
}
