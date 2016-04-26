using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CS6 by Jim Harris - CIS162AD

namespace CS6
{
    public partial class CS6Form : Form
    {
        public CS6Form()
        {
            InitializeComponent();
        }

        // Declare class-level variables and constants
        // Class variables are initialized to zero when declared

        int cintEmployeeCount;
        decimal cdecTotalNetPay;

        const decimal cdecFICA_RATE = 0.06M;
        const decimal cdecFEDERAL_RATE = 0.15M;
        const decimal cdecSTATE_RATE = 0.05M;

        const decimal cdecNONE_UNION_DUES = 0.00M;
        const decimal cdecREGULAR_UNION_DUES = 5.00M;
        const decimal cdecSPECIAL_UNION_DUES = 10.00M;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // declare method variables
            int intHoursWorked;
            decimal decPayRate;

            decimal decGross;
            decimal decFica;
            decimal decFederal;
            decimal decState;
            decimal decNetpay;
            decimal decAverageNetpay;

            decimal decUnionDues;

            // Input:
            // Use nested try-catch blocks to get the input values

            try
            {
                intHoursWorked = int.Parse(txtHoursWorked.Text);

                try
                {
                    decPayRate = decimal.Parse(txtPayRate.Text);

                    // Process:
                    // We now have hours worked and payrate
                    // Continue processing by performing calculations.

                    // Check if values are in range
                    if (intHoursWorked >= 1 && intHoursWorked <= 50)
                    {

                        if (decPayRate >= 10.00M && decPayRate <= 15.00M)
                        {

                            // Inputted values are valid - Continue processing                             

                            // Calculate gross, adjust for overtime
                            decGross = calcGross(intHoursWorked, decPayRate);

                            //Determine union dues
                            decUnionDues = setUnionDues();

                            //The 2-4th arguments are call-by-reference, so the values are
                            // "returned" through the arguments.  
                            calcTaxes(decGross, out decFica, out decFederal, out decState);                           

                            decNetpay = decGross - (decFica + decFederal + decState + decUnionDues);

                            cdecTotalNetPay += decNetpay;
                            cintEmployeeCount += 1;

                            // calc avg net pay
                            decAverageNetpay = calcAverage();

                            // Output:
                            // We now have all the values to display

                            lblGrossPayValue.Text = decGross.ToString("C");
                            lblFicaTaxValue.Text = decFica.ToString("C");
                            lblFedTaxValue.Text = decFederal.ToString("C");
                            lblStateTaxValue.Text = decState.ToString("C");
                            lblNetPayValue.Text = decNetpay.ToString("C");

                            lblTotalNetPayValue.Text = cdecTotalNetPay.ToString("C");
                            lblEmployeeCountValue.Text = cintEmployeeCount.ToString("N0");
                            lblAvgNetPayValue.Text = decAverageNetpay.ToString("C");
                        }
                        else
                        {

                            //Handle invalid pay rate
                            MessageBox.Show("Pay rate must be between $10.00 and $15.00. ",
                                "Data Entry Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            txtHoursWorked.SelectAll();
                            txtHoursWorked.Focus();

                        }

                    }
                    else
                    {

                        //Handle invalid hours
                        MessageBox.Show("Hours must be between 1 and 50. ",
                            "Data Entry Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        txtHoursWorked.SelectAll();
                        txtHoursWorked.Focus();

                    }


                }
                catch (FormatException err)
                {

                    MessageBox.Show("Pay rate must be numeric.  " + err.Message,
                                            "Data Entry Error", MessageBoxButtons.OK,
                                            MessageBoxIcon.Exclamation);
                    txtPayRate.SelectAll();
                    txtPayRate.Focus();
   
                }

            }

            // Handle exceptions for hours worked
            catch (FormatException err)
            {

                MessageBox.Show("Hours Worked must be numeric.  " + err.Message,
                                                        "Data Entry Error", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Exclamation);
                txtHoursWorked.SelectAll();
                txtHoursWorked.Focus();
            }

            // Handle all other types of exceptions. Exceptions not caught by the inner
            // Try will also end up here because that Try is inside the outer Try.
            catch (Exception err)
            {
                MessageBox.Show("Unexpected Error: " + err.Message);
            }

        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            // User Clear or null string "" for TextBoxes, but
            // only use null string "" for Labels

            txtHoursWorked.Clear();
            txtPayRate.Clear();

            lblAvgNetPayValue.Text = "";   // null string
            lblEmployeeCountValue.Text = "";
            lblFedTaxValue.Text = "";
            lblFicaTaxValue.Text = "";
            lblGrossPayValue.Text = "";
            lblNetPayValue.Text = "";
            lblStateTaxValue.Text = "";
            lblTotalNetPayValue.Text = "";

            cdecTotalNetPay = 0;  // Reset Accumulators
            cintEmployeeCount = 0;

            radNone.Checked = true;  // Set radio button group to 'None' selection

            txtHoursWorked.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //calculation methods
        private decimal calcGross(int intHoursWorked, decimal decPayRate)
        {
            //Variables listed as arguments are declared as local variables

            decimal decGross;

            // Calculate gross, adjust for overtime
            if (intHoursWorked <= 40)
                decGross = intHoursWorked * decPayRate;
            else
                decGross = (40 * decPayRate) + ((intHoursWorked - 40) * decPayRate * 1.5M);

            return decGross;
        }

        // Example using call by refs
        private void calcTaxes(decimal decGross, out decimal decFica,  out decimal decState, out decimal decFederal)
        {

            //void means that a value will not be returned through the return statement.

            //  Call-by-reference arguments can be ref or out.
            //  ref means that the variable will be initialized before the call.
            //  out means that the variable may not have been initialized, and 
            //  that the current method will be assigning a value to the variable.
            //  out prevents the compiler from generating an error.

            decFica = decGross * cdecFICA_RATE;
            decFederal = decGross * cdecFEDERAL_RATE;
            decState = decGross * cdecSTATE_RATE;
        }

        // This method only uses class variables
        private decimal setUnionDues( )
        {
            decimal decUnionDues;

            //Determine union dues
            if (radSpecial.Checked == true)
                decUnionDues = cdecSPECIAL_UNION_DUES;
            else if (radRegular.Checked == true)
                decUnionDues = cdecREGULAR_UNION_DUES;
            else
                decUnionDues = cdecNONE_UNION_DUES;

            return decUnionDues;
        }

        // This method only uses class variables
        private decimal calcAverage()
        {
            return cdecTotalNetPay / cintEmployeeCount;            
        }

 

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuEditCalc_Click(object sender, EventArgs e)
        {
            btnCalculate_Click(sender, e);
        }

        private void mnuEditClear_Click(object sender, EventArgs e)
        {
            btnClearForm_Click(sender, e);
        }

        private void mnuEditFont_Click(object sender, EventArgs e)
        {

            //fontDialog1 object is created using the FontDialog
            //control on the form, otherwise need to create here:
            //   FontDialog fontDialog1 = new FontDialog();

            //Use the current settings as the default in the dialog box
            fontDialog1.Font = lblTotalNetPayValue.Font;

            //Display dialog box so user can pick a font
            //Apply the font chosen to the Totals section if not Canceled
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblTotalNetPayValue.Font = fontDialog1.Font;
                lblEmployeeCountValue.Font = fontDialog1.Font;
                lblAvgNetPayValue.Font = fontDialog1.Font;
            }

        }

        private void mnuEditColor_Click(object sender, EventArgs e)
        {

            //colorDialog1 object is created using the ColorDialog
            //control on the form, otherwise need to create here:
            //   ColorDialog colorDialog1 = new ColorDialog();

            //Use the current settings as the default in the dialog box
            colorDialog1.Color = lblTotalNetPayValue.ForeColor;

            //Display dialog box so user can pick a color
            //Apply the color chosen to the Totals section if not Canceled
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                lblTotalNetPayValue.ForeColor = colorDialog1.Color;
                lblEmployeeCountValue.ForeColor = colorDialog1.Color;
                lblAvgNetPayValue.ForeColor = colorDialog1.Color;
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

        private void contextMnuFont_Click(object sender, EventArgs e)
        {
            mnuEditFont_Click(sender, e);
        }

        private void contextMnuColor_Click(object sender, EventArgs e)
        {
            mnuEditColor_Click(sender, e);
        }

 



    }
}
