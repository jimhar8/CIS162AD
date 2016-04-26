using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CS5 by Jim Harris - CIS162AD

namespace CS6
{
    public partial class CS5Form : Form
    {
        public CS5Form()
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
                            if (intHoursWorked <= 40)
                                decGross = intHoursWorked * decPayRate;
                            else
                                decGross = (40 * decPayRate) + ((intHoursWorked - 40) * decPayRate * 1.5M);


                            //Determine shipping amount
                            if (radSpecial.Checked == true)
                                decUnionDues = cdecSPECIAL_UNION_DUES;
                            else if (radRegular.Checked == true)
                                decUnionDues = cdecREGULAR_UNION_DUES;
                            else
                                decUnionDues = cdecNONE_UNION_DUES;

                             decFica = decGross * cdecFICA_RATE;
                            decFederal = decGross * cdecFEDERAL_RATE;
                            decState = decGross * cdecSTATE_RATE;

                            decNetpay = decGross - (decFica + decFederal + decState + decUnionDues);

                            cdecTotalNetPay += decNetpay;
                            cintEmployeeCount += 1;
                            decAverageNetpay = cdecTotalNetPay / cintEmployeeCount;

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

    }
}
