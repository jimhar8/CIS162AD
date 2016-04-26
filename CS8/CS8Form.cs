using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:       CS8 Classes
//Programmer:    Juan Marquez (Modified by Jim Harris)
//Description:   Driver program used to test Customer and Order classes.

namespace CS8
{
    public partial class frmCS8 : Form
    {
        public frmCS8()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strMailingLabel;

            try
            {
                if (chkPreferredDiscount.Checked == true)
                {
                    // Create an instance of clsOrderPreferred
                    clsOrderPreferred cobjOrder = new clsOrderPreferred(txtDescription.Text,
                        int.Parse(txtQuantity.Text), decimal.Parse(txtPrice.Text));

                    // calculate Extended price, uses overrided method in child class
                    cobjOrder.calcExtendedPrice();
                    
                    // Accumulate totals
                    cobjOrder.accumulateTotals();

                    // Display Extended Price
                    lblExtension.Text = cobjOrder.ExtendedPrice.ToString("C");

                }
                else
                {
                    // Create an instance of clsOrder
                    clsOrder cobjOrder = new clsOrder(txtDescription.Text,
                        int.Parse(txtQuantity.Text), decimal.Parse(txtPrice.Text));

                    // calculate Extended price
                    cobjOrder.calcExtendedPrice();

                    // Accumulate totals
                    cobjOrder.accumulateTotals();

                    // Display Extended Price
                    lblExtension.Text = cobjOrder.ExtendedPrice.ToString("C");
                } // end if-else

                //Create an instance of clsCustomer using the overloaded constructor
                clsCustomer cobjCustomer = new clsCustomer(txtName.Text, txtStreet.Text,
                                    txtCity.Text, txtState.Text, txtZip.Text);

                //Build mailing label using the Get methods for Customer.
                strMailingLabel = cobjCustomer.Name + "\n" +
                                  cobjCustomer.Street + "\n" +
                                  cobjCustomer.City + ", " +
                                  cobjCustomer.State + "  " + cobjCustomer.Zip;

                //Display mailing address
                lblMailingLabel.Text = strMailingLabel;

                //Shared properties are accessed using class name
                //Test the Get Property methods of ReadOnly Shared properties 
                lblTotalCount.Text = clsOrder.TotalCount.ToString("N0");
                lblTotalPrice.Text = clsOrder.TotalPrice.ToString("C");

            } // end try
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message
                                + "\n" + ex.StackTrace,
                                "Try/Catch - Unexpected Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end catch
        }


        private void btnNextItem_Click(object sender, EventArgs e)
        {
            //clear the item fields
            txtDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            lblExtension.Text = "";

            txtDescription.Focus();
        }


        private void btnResetSummary_Click(object sender, EventArgs e)
        {
            //Reset totals using the class name to access the shared method
            clsOrder.resetTotals();

            lblTotalPrice.Text = "";
            lblTotalCount.Text = "";
            lblMailingLabel.Text = "";

            //Clear the rest of the form using next item method
            btnNextItem_Click(sender, e);    
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}