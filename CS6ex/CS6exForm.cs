using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS7ex by Your Name - CIS162AD
/*     
    This project is a re-write of CS5ex using Menus, Dialog Boxes,
    and Methods. Methods are used to calculate extended price, sales tax,
    total due, and average sales.
*/
namespace CS7ex
{
    public partial class CS6exForm : Form
    {
        public CS6exForm()
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
                    decPrice = decimal.Parse(txtPrice.Text);
                
                    //Process:
                    //We now have a numeric quantity and price.
                    //Check if values are within the range
                    if (intQuantity >= 1 && intQuantity <= 50)
                        if (decPrice >= 5.00M && decPrice <= 15.00M)
                        {
                            //Values are valid
                            //Perform calculations using Methods
                            //Local values are sent to the methods through the arguments
                            //Local variables are assigned the values returned by each method
                            decExtendedPrice = calcExtendedPrice(intQuantity, decPrice);
                            decSalesTax = calcSalesTax(decExtendedPrice);
                            decShipping = setShipping();

                            //The 4th argument is a call-by-reference, so the value is
                            //"returned" through the argument.  See comments in method.
                            calcTotalDue(decExtendedPrice, decSalesTax, decShipping, out decTotalDue);

                            //Accumulate summary totals
                            cdecGrandTotal += decTotalDue;
                            cintOrderCount += 1;
                            decAverageOrder = calcAverage( );

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

            radGround.Checked = true;
            chkSalesTax.Checked = false;

            cdecGrandTotal = 0;		//Reset Accumulators
            cintOrderCount = 0;

            txtQuantity.Focus();

        }//end of btnClearForm


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end of btnExit


//calculation methods
        private decimal calcExtendedPrice(int intQuantity, decimal decPrice)
        {
            //Variables listed as arguments are declared as local variables
            //Declare additional local variables in the body if needed
            //Discount Rate is a class (global) variable, so it is not an argument
            //
            //Instead of having multiple return statements, the result of the
            //if statement is stored and then returned at the end of the method

            decimal decExtendedPrice;

            if (intQuantity > 25)
                decExtendedPrice = intQuantity * (decPrice * cdecDISCOUNT_RATE);
            else
                decExtendedPrice = intQuantity * decPrice;

            return decExtendedPrice;
        }


        private decimal calcSalesTax(decimal decExtendedPrice)
        {
            //Tax Rate is a class (global) variable, so it is not an argument
            //When the intermediate result is not needed, 
            //  the calculation may be placed in the return statement

            if (chkSalesTax.Checked == true)
                return (decExtendedPrice * cdecTAX_RATE);
            else
                return 0M;   //return a zero
        }


        private decimal setShipping()
        {
            //return the shipping rate
            if (radNextDay.Checked == true)
                return (cdecNEXT_DAY_SHIPPING_RATE);
            else if (radThreeDay.Checked == true)
                return (cdecTHREE_DAY_SHIPPING_RATE);
            else
                return (cdecGROUND_SHIPPING_RATE);
        }


        private void calcTotalDue(decimal decExtendedPrice, decimal decSalesTax,
                decimal decShipping, out decimal decTotalDue)
        {
            //void means that a value will not be returned through the return statement.

            //Call-by-reference arguments can be ref or out.
            //ref means that the variable will be initialized before the call.
            //out means that the variable may not have been initialized, and 
            //  that the current method will be assigning a value to the variable.
            //  out prevents the compiler from generating an error.

            decTotalDue = decExtendedPrice + decSalesTax + decShipping;

            return;
        }


        private decimal calcAverage()
        {
            //Grand total and count are class variables so they are not passed as arguments.
            return (cdecGrandTotal / cintOrderCount);
        }


//Menu options
        //Implement Calculate Menu option by calling existing button method
        private void mnuEditCalculate_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        //Implement Clear Form Menu option by calling existing button method
        private void mnuEditClearForm_Click(object sender, EventArgs e)
        {
            btnClearForm_Click(sender, e);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mnuEditFont_Click(object sender, EventArgs e)
        {
            //fontDialog1 object is created using the FontDialog
            //control on the form, otherwise need to create here:
            //   FontDialog fontDialog1 = new FontDialog();

            //Use the current settings as the default in the dialog box
            fontDialog1.Font = lblGrandTotal.Font;

            //Display dialog box so user can pick a font
            //Apply the font chosen to the Totals section if not Canceled
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblGrandTotal.Font = fontDialog1.Font;
                lblNumberOfOrders.Font = fontDialog1.Font;
                lblAverageOrder.Font = fontDialog1.Font;
            }
        }

        private void mnuEditColor_Click(object sender, EventArgs e)
        {
            //colorDialog1 object is created using the ColorDialog
            //control on the form, otherwise need to create here:
            //   ColorDialog colorDialog1 = new ColorDialog();

            //Use the current settings as the default in the dialog box
            colorDialog1.Color = lblGrandTotal.ForeColor;

            //Display dialog box so user can pick a color
            //Apply the color chosen to the Totals section if not Canceled
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblGrandTotal.ForeColor = colorDialog1.Color;
                lblNumberOfOrders.ForeColor = colorDialog1.Color;
                lblAverageOrder.ForeColor = colorDialog1.Color;
            }

            //Note on FontDialog and Color:
            //A color selector may be added to the FontDialog if the only
            //only color options desired are the 16 basic colors.  Before showing
            //the FontDialog box in the mnuEditFont method above, activate 
            //the color option:
            //      fontDialog1.ShowColor = true;
            //and set the Color to the currently selected fore color:
            //      fontDialog1.Color = lblGrandTotal.ForeColor;
            //After the user selects the a color, apply the color:
            //      lblGrandTotal.ForeColor = fontDialog1.Color;
            //
            //However, ColorDialog must be used for custom colors.
            //AutoFullOpen is set to true by default, which is the
            //property that allows custom colors to be defined.
        }

//Context Menu options attached to form
        private void contextMnuFont_Click(object sender, EventArgs e)
        {
            mnuEditFont_Click(sender, e);
        }

        private void contextMnuColor_Click(object sender, EventArgs e)
        {
            mnuEditColor_Click(sender, e);
        }

    }//end of class
}//end of namespace