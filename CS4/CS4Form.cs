using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CS4 by Jim Harris - CIS162AD

namespace CS4
{
    public partial class CS4Form : Form
    {
        public CS4Form()
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
        const decimal cdecUNION_DUES = 10.00M;


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

                    decGross = intHoursWorked * decPayRate;
                    decFica = decGross * cdecFICA_RATE;
                    decFederal = decGross * cdecFEDERAL_RATE;
                    decState = decGross * cdecSTATE_RATE;
                    decNetpay = decGross - (decFica + decFederal + decState + cdecUNION_DUES);

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

        private void lblTotalNetPayValue_Click(object sender, EventArgs e)
        {

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

            txtHoursWorked.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CS4Form_Load(object sender, EventArgs e)
        {

        }
    }
}
