using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS13
{
    public partial class frmCS13A : Form
    {
        public frmCS13A()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cs13_databasesDataSet);

        }

        private void CS13FormA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cs13_databasesDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cs13_databasesDataSet.Customer);

        }
    }
}
