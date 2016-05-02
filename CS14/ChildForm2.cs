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
    public partial class frmChild2 : Form
    {
        public frmChild2()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionRange.Start +
                         " - " + monthCalendar1.SelectionRange.End;
        }
    }
}
