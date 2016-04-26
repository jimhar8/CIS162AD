using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:     CS12 Array Processing
//Programmer:  Jim Harris
//Description: Load a list of Customer Ids, Names, and Discount Codes from a file.
//             The list can hold up to 10 customers.
//             Lookup the discount code in a array to get the discount Rate. 
//             Data is displayed in list boxes.
//             The user can sort the list by Id or Name and search by name.

using System.IO;  // FileStream and StreamReader

namespace CS12
{
    public partial class frmCS12 : Form
    {
        public frmCS12()
        {
            InitializeComponent();
        }

        //Declare class-level arrays
        const int cintARRAY_SIZE = 10;  //used to declare arrays

        int[] cintId = new int[cintARRAY_SIZE];
        string[] cstrName = new string[cintARRAY_SIZE];
        string[] cstrDiscCode = new string[cintARRAY_SIZE];
        decimal[] cdecRate = new decimal[cintARRAY_SIZE];

 
        //Use cintNumberOfCustomers to process arrays because arrays 
        //may be partially loaded.  Count set in LoadArrays.
        int cintNumberOfCustomers;

        //Declare constant arrays
        //Size of array determined by the number of values provided.
        //Note the values are enclosed in braces and not parenthesis.

        decimal[] cdecDISC_RATE = new decimal[] { 0.03M, 0.05M, 0.10M, 0.00M };
        string[] cstrDISC_CODE = new string[] { "A", "F", "S", "X"};


        private void btnLoadArrays_Click(object sender, EventArgs e)
        {

            int i = 0; // subscript initialized to zero

            //Note:
            //cstrName.Length is the number of entries that can be loaded.
            //The last valid subscript value is one less than Length.
            //cstrName.GetUpperBound(0) is last valid subscript value.
            //In this example:
            //   cstrName.Length = 10
            //   cstrName.GetUpperBound(0) = 9

            try
            {
                //Load the arrays with the data in the file
                FileStream customerFile = new FileStream("cs12.txt", FileMode.Open);
                StreamReader customerStreamReader = new StreamReader(customerFile);

                while (customerStreamReader.Peek() > -1)  // jh:  seem to have extra CR in file
                {

                    if (i < cstrName.Length)
                    {
                        cintId[i] = int.Parse(customerStreamReader.ReadLine());
                        cstrName[i] = customerStreamReader.ReadLine();
                        cstrDiscCode[i] = customerStreamReader.ReadLine();
                        i++;
                    }
                    else
                    {
                        MessageBox.Show("Error:  Programmer Array Size Exceeded", "Array size exceeded", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                        break;  // break out of while loop
                    }
                }

                customerFile.Close(); // close file

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in opening customer data file", "File not found" + ex.Message, MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
            }

            cintNumberOfCustomers = i;
            assignDiscountRate();
            displayArrays();
            btnLoadArrays.Enabled = false;  // Load only once

 
        }


        void assignDiscountRate()
        {

            int cu;  // customer index
            int co;  // discount code index

            //  outer loop walks through customers
            //  inner loop looks up customer discount codes

            for (cu = 0; cu < cintNumberOfCustomers; cu++)
            {
                for (co = 0; co < cstrDISC_CODE.GetUpperBound(0); co++)
                {
                    if (cstrDiscCode[cu] == cstrDISC_CODE[co])
                    {
                        cdecRate[cu] = cdecDISC_RATE[co];
                        break; // break out of inner loop, found item
                    }

                } // next discount code
            } // next customer
 
        }


        void displayArrays()
        {

            int i;

            //In the default font, the Letter L and the number One 
            //look very similar - L = l, One = 1.
            //Listbox names beging with the letter L, and
            //not with the number one. 

            //Listboxes need to be cleared because this procedure
            //is also called to redisplayed the data.

            lstCode.Items.Clear();
            lstId.Items.Clear();
            lstName.Items.Clear();
            lstRate.Items.Clear();


            //Use cintNumberOfCustomers to process a partially filled array
            //cintNumberOfCustomers is like Length, so we need to subtract one
            //to get the subscript value of the last entry.

            for (i = 0; i < cintNumberOfCustomers; i++)
            {
                lstId.Items.Add(cintId[i].ToString());
                lstName.Items.Add(cstrName[i]);
                lstCode.Items.Add(cstrDiscCode[i]);
                lstRate.Items.Add(cdecRate[i].ToString("N2"));
                
            }//next i - customer
 
        }


        private void btnSortById_Click(object sender, EventArgs e)
        {
            int i;
            int i2;
            int intMinId;
            int intMinSubscript;

            //outer loop keeps track of where the next value
            //should be placed.
            for (i = 0; i < cintNumberOfCustomers - 1; i++)
            {
                intMinSubscript = i;
                intMinId = cintId[i];

                //inner loop finds the lowest value to move up
                for (i2 = i + 1; i2 < cintNumberOfCustomers; i2++)
                {
                    //Only == and != can be used with strings, use CompareTo 
                    if (cintId[i2] < intMinId)
                    {
                        //save the new low value found
                        intMinId = cintId[i2];
                        intMinSubscript = i2;
                    }
                }//next i2 

                swapArrayValues(i, intMinSubscript);
            }//next i

            //display arrays in list boxes
            displayArrays();



        }


        void swapArrayValues(int i, int intMinSubscript)
        {

            //With parallel arrays, all corresponding data must be
            //swapped across arrays so that all associated data 
            //stays on the same row.

            string strHoldValue;
            int intHoldValue;
            decimal decHoldValue;

            intHoldValue = cintId[i];
            cintId[i] = cintId[intMinSubscript];
            cintId[intMinSubscript] = intHoldValue;

            strHoldValue = cstrName[i];
            cstrName[i] = cstrName[intMinSubscript];
            cstrName[intMinSubscript] = strHoldValue;

            strHoldValue = cstrDiscCode[i];
            cstrDiscCode[i] = cstrDiscCode[intMinSubscript];
            cstrDiscCode[intMinSubscript] = strHoldValue;

            decHoldValue = cdecRate[i];
            cdecRate[i] = cdecRate[intMinSubscript];
            cdecRate[intMinSubscript] = decHoldValue;

 
        }
		

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            int i;
            int i2;
            string strMinName;
            int intMinSubscript;

            //outer loop keeps track of where the next value
            //should be placed.
            for (i = 0; i < cintNumberOfCustomers - 1; i++)
            {
                intMinSubscript = i;
                strMinName = cstrName[i];

                //inner loop finds the lowest value to move up
                for (i2 = i + 1; i2 < cintNumberOfCustomers; i2++)
                {
                    //Only == and != can be used with strings, use CompareTo 
                    if (cstrName[i2].CompareTo(strMinName) < 0)
                    {
                        //save the new low value found
                        strMinName = cstrName[i2];
                        intMinSubscript = i2;
                    }
                }//next i2 

                swapArrayValues(i, intMinSubscript);
            }//next i

            //display arrays in list boxes
            displayArrays();


        }


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            //Include Early Exit logic
            //An early exit from a search can occur when we know that
            //the value we are looking for will not be found in the array.  To
            //implement an early exit, the array most be sorted ascending.
            //If we can determine that a value will not be found, we should
            //not search the remainder of the array.


            int i;
            bool blnNameFound = false;

            //array must be sorted ascending for early exit logic to work
            btnSortByName_Click(sender, e);

            //Clear message box
            txtSearchResults.Clear();

            for (i = 0; i < cintNumberOfCustomers; i++)
            {
                if (txtSearchName.Text.ToUpper() == cstrName[i].ToUpper())
                {
                    blnNameFound = true;
                    txtSearchResults.Text = "Matching name is selected in list box.";
                    lstName.SelectedIndex = i;
                    lstCode.SelectedIndex = i;
                    lstRate.SelectedIndex = i;
                    lstId.SelectedIndex = i;

                    break; //exit for loop
                }
                else if (txtSearchName.Text.ToUpper().CompareTo(cstrName[i].ToUpper()) < 0)
                {
                    txtSearchResults.Text = "Match not found - Early Exit taken";
                    break; //exit for loop
                }//end if
            }//next i

            if (blnNameFound == false && txtSearchResults.Text == "")
                txtSearchResults.Text = "Match not found - Reached end of array";

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchResults_TextChanged(object sender, EventArgs e)
        {

        }

    }//end of class
}//end of namespace
