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

namespace CS9ex
{
    public partial class frmCS9ex : Form
    {
        public frmCS9ex()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkUnionMember.Checked == true)
                {
                    //Create an instance of clsEmployeeUnion
                    clsEmployeeUnion cobjEmployee = new clsEmployeeUnion
                        (txtName.Text,
                         int.Parse(txtHours.Text),
                         decimal.Parse(txtRate.Text));

                    //Test the calculations methods
                    cobjEmployee.calcGross();
                    cobjEmployee.setUnionDues();  //using redefined method
                    cobjEmployee.calcNetPay();

                    //accumlate totals
                    cobjEmployee.accumulateTotals();

                    //Test the Get property methods
                    lblGross.Text = cobjEmployee.Gross.ToString("C");
                    lblUnionDues.Text = cobjEmployee.UnionDues.ToString("C");
                    lblNetPay.Text = cobjEmployee.NetPay.ToString("C");
                }
                else
                {
                    //Create an instance of clsEmployee
                    clsEmployee cobjEmployee = new clsEmployee
                        (txtName.Text,
                         int.Parse(txtHours.Text),
                         decimal.Parse(txtRate.Text));

                    //Test the calculations methods
                    cobjEmployee.calcGross();
                    cobjEmployee.setUnionDues();  //using 1st definition of method
                    cobjEmployee.calcNetPay();

                    //accumlate totals
                    cobjEmployee.accumulateTotals();

                    //Test the Get property methods
                    lblGross.Text = cobjEmployee.Gross.ToString("C");
                    lblUnionDues.Text = cobjEmployee.UnionDues.ToString("C");
                    lblNetPay.Text = cobjEmployee.NetPay.ToString("C");
                }

                //Shared properties can be accessed using class name
                //Object names are declared locally in if statement
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