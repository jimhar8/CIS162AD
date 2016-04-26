using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS5ex by Your Name - CIS162AD
/*    
    This project uses if statements to validate the 
    quantity and price entered.  If valid, they are used
    to calculate the extended price, sales tax, shipping, 
    and total due.  If the quantity is greater than 25, a
    discount of 2% is given. The extended price is accumulated
    to determine the total of all of the orders entered.
    The number of orders entered are also counted, and 
    the accumulated extended price and number of orders entered
    are used to calculate the average order amount.
    Constants are used to store the sales tax and shipping rates.
*/
namespace CS5ex
{
    public partial class CS5exForm : Form
    {
        public CS5exForm()
        {
            InitializeComponent();
        }

		//Declare class-level variables and constants
		//Class variables are initialized to zero when declared
		int cintOrderCount;
		decimal cdecGrandTotal;

        const decimal cdecTAX_RATE = 0.08M;
        const decimal cdecDISCOUNT_RATE = .98M;  //98% of the price is a 2% discount
        const decimal cdecGROUND_SHIPPING_RATE = 5.00M;
        const decimal cdecTHREE_DAY_SHIPPING_RATE = 7.00M;
        const decimal cdecNEXT_DAY_SHIPPING_RATE = 10.00M;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
			// declare method variables
			int intQuantity;
			decimal decPrice;
			decimal decExtendedPrice;
			decimal decSalesTax;
            decimal decShipping;
			decimal decTotalDue;
			decimal decAverageOrder;
 
			//Input:
			//Use nested try-catch blocks to get the input values
			try
			{
				intQuantity = int.Parse(txtQuantity.Text);
				try
				{
					decPrice = decimal.Parse (txtPrice.Text);
                                    
                    //Process:
                    //We now have a numeric quantity and price.
                    //Check if values are within the range
                    if (intQuantity >= 1 && intQuantity <= 50)
                        if (decPrice >= 5.00M && decPrice <= 15.00M)
                        {
                            //Values are valid - Continue processing 

                            //Determine if discount should be applied
                            if (intQuantity > 25)
                                decExtendedPrice = intQuantity * (decPrice * cdecDISCOUNT_RATE);
                            else
                                decExtendedPrice = intQuantity * decPrice;

                            //Calculate sales tax if taxable
                            if (chkSalesTax.Checked == true)
                                decSalesTax = decExtendedPrice * cdecTAX_RATE;
                            else
                                decSalesTax = 0M;

                            //Determine shipping amount
                            if (radNextDay.Checked == true)
                                decShipping = cdecNEXT_DAY_SHIPPING_RATE;
                            else if (radThreeDay.Checked == true)
                                decShipping = cdecTHREE_DAY_SHIPPING_RATE;
                            else
                                decShipping = cdecGROUND_SHIPPING_RATE;

                            //Sum to get the total due
                            decTotalDue = decExtendedPrice + decSalesTax + decShipping;

                            //Accumulate summary totals
                            cdecGrandTotal += decTotalDue;
                            cintOrderCount += 1;
                            decAverageOrder = cdecGrandTotal / cintOrderCount;

    					    //Output:
	    				    //We now have all of the values to display
		    			    lblExtendedPrice.Text = decExtendedPrice.ToString("C");  //Currency
			    		    lblSalesTax.Text = decSalesTax.ToString("C");
				    	    lblShipping.Text = decShipping.ToString("C");
					        lblTotalDue.Text = decTotalDue.ToString("C");

    					    lblGrandTotal.Text = cdecGrandTotal.ToString("C");
	    				    lblNumberOfOrders.Text = cintOrderCount.ToString("N0"); //Number
		    			    lblAverageOrder.Text = decAverageOrder.ToString("C");

                            txtQuantity.Focus();    //get ready for next input
                        }
                        else
                        {
                            //Handle invalid price
                            MessageBox.Show("Price must be between $5.00 and $15.00. ", 
                                "Data Entry Error", MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);
	    				    txtPrice.SelectAll();
		    			    txtPrice.Focus();
                        }//endif
                    else
                    {
                        //Handle invalid quantity
                        MessageBox.Show("Quantity must be between 1 and 50. ",
                            "Data Entry Error", MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
			    	    txtQuantity.SelectAll();
				        txtQuantity.Focus();
                    }//endif
                }//inner try
                //Handle exceptions for price
                catch (FormatException err)
                {
                    MessageBox.Show("Price must be numeric. " + err.Message,
                        "Data Entry Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtPrice.SelectAll();
                    txtPrice.Focus();
                }
            }//outer try
            //Handle exceptions for quantity
            catch (FormatException err)
            {
                MessageBox.Show("Quantity must be numeric. " + err.Message,
                    "Data Entry Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtQuantity.SelectAll();
                txtQuantity.Focus();
            }
            //Handle any other exceptions.  Exceptions not caught by the 
            //inner Try will also end up here because that Try is inside the outer Try.  
            catch(Exception err)
            {
                MessageBox.Show("Unexpected Error: " + err.Message);
            }
		}//end of btnCalculate


        private void btnClearForm_Click(object sender, EventArgs e)
        {
            //Use Clear or null string "" for TextBoxes, but
            //only use null string "" for Labels

            txtQuantity.Clear();		//Clear
            txtPrice.Clear();

            lblExtendedPrice.Text = "";   //null string
            lblSalesTax.Text = "";
            lblShipping.Text = "";
            lblTotalDue.Text = "";
            lblGrandTotal.Text = "";
            lblNumberOfOrders.Text = "";
            lblAverageOrder.Text = "";

            radGround.Checked = true;    //reset radio buttons 
            chkSalesTax.Checked = false; //reset check box

            cdecGrandTotal = 0;		//Reset Accumulators
            cintOrderCount = 0;

            txtQuantity.Focus();

        }//end of btnClearForm


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of btnExit

    }//end of class
}//end of namespace