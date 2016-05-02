using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS14
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuWindowCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuWindowTileHorizontally_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tbbChild1_Click(object sender, EventArgs e)
        {

            frmChild1 frmChild1Obj = new frmChild1();
            frmChild1Obj.MdiParent = this;              //this points to the parent form
            frmChild1Obj.Show();

        }

        private void tbbChild2_Click(object sender, EventArgs e)
        {

            frmChild2 frmChild2Obj = new frmChild2();
            frmChild2Obj.MdiParent = this;              //this points to the parent form
            frmChild2Obj.Show();

        }
    }
}
