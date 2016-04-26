using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS2
{
    public partial class frmCS2 : Form
    {
        public frmCS2()
        {
            InitializeComponent();
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {

            lblDepartment.Text = "Marketing";
            lblContact.Text = "Michelle Tyler";
            lblPhone.Text = "500-2222";

        }

        private void btnCustRelations_Click(object sender, EventArgs e)
        {

            lblDepartment.Text = "Customer Relations";
            lblContact.Text = "Tricia Smith";
            lblPhone.Text = "500-1111";

        }

        private void btnOrderProcessing_Click(object sender, EventArgs e)
        {

            lblDepartment.Text = "Order Processing";
            lblContact.Text = "Kenna Ross";
            lblPhone.Text = "500-3333";

        }

        private void btnShipping_Click(object sender, EventArgs e)
        {

            lblDepartment.Text = "Shipping";
            lblContact.Text = "Eric Johnson";
            lblPhone.Text = "500-4444";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
