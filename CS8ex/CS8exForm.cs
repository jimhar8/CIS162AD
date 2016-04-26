using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS8ex - Juan Marquez- CIS162AD
/*
  	This project uses classes to calculate gross and net pay.

    Shared (static) variables are used in class to accumulate totals.

*/

namespace CS8ex
{
    public partial class frmCS8ex : Form
    {
        public frmCS8ex()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of clsEmployee
                //Assign values in textboxes to class variables using the overloaded constructor

                clsEmployee cobjEmployee = new clsEmployee
                    (txtName.Text,
                     int.Parse(txtHours.Text),
                     decimal.Parse(txtRate.Text));

                //Test the calculations methods
                cobjEmployee.calcGross();
                cobjEmployee.setUnionDues();
                cobjEmployee.calcNetPay();

                //Update the totals in shared variables.
                cobjEmployee.accumulateTotals();

                //Test the Get property methods
                lblGross.Text = cobjEmployee.Gross.ToString("C");
                lblUnionDues.Text = cobjEmployee.UnionDues.ToString("C");
                lblNetPay.Text = cobjEmployee.NetPay.ToString("C");

                //Shared properties are accessed using class name
                //Test the Get Property methods of ReadOnly Shared properties 
                lblTotalGross.Text = clsEmployee.TotalGross.ToString("C");
                lblTotalNetPay.Text = clsEmployee.TotalNetPay.ToString("C");
                lblTotalCount.Text = clsEmployee.TotalCount.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message
                                + "\n" + ex.StackTrace,
                                "Try/Catch - Unexpected Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end try

    	}//end of btnCalculate
        

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //Use Clear or null string "" for TextBoxes, but
            //only use null string "" for Labels

            txtName.Clear();
            txtHours.Clear();		//Clear
            txtRate.Clear();

            lblGross.Text = "";   //null string
            lblUnionDues.Text = "";
            lblNetPay.Text = "";
            lblTotalGross.Text = "";
            lblTotalNetPay.Text = "";
            lblTotalCount.Text = "";

            chkUnionMember.Checked = false;

            //Reset Totals in class shared variables
            clsEmployee.resetTotals();

            txtName.Focus();

        }//end of btnClearForm

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//end of class
}//end of namespace