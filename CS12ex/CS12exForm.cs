using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Project:     CS12ex Array Processing
//Programmer:  Juan Marquez
//Description: Load a list of Students and Percentage points from a file. 
//             Lookup the percentage to get a letter grade. 
//             Display the data in list boxes.
//             Data can sorted by Name or Percent and searched by name.
//
//			   Need System.IO for FileStream and StreamReader

using System.IO;  // FileStream and StreamReader

namespace CS12ex
{
    public partial class frmCS12ex : Form
    {
        public frmCS12ex()
        {
            InitializeComponent();
        }

        //Declare class-level arrays
        const int cintARRAY_SIZE = 9;  //used to declare arrays
        string[] cstrName = new string[cintARRAY_SIZE];
        decimal[] cdecPercent = new decimal[cintARRAY_SIZE];
        string[] cstrGrade = new string[cintARRAY_SIZE];

        //Use cintNumberOfStudents to process arrays because arrays 
        //may be partially loaded.  Count set in LoadArrays.
        int cintNumberOfStudents;

        //Declare constant arrays
        //Size of array determined by the number of values provided.
        //Note the values are enclosed in braces and not parenthesis.
        decimal[] cdecPERCENT_RANGE = new decimal[] { 90M, 80M, 70M, 60M, 0M };

        string[] cstrLETTER_GRADE = new string[] { "A", "B", "C", "D", "F" };


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
                FileStream studentFile = new FileStream("cs12ex.txt", FileMode.Open);
                StreamReader studentStreamReader = new StreamReader(studentFile);
                while (studentStreamReader.Peek() != -1)
                {
                    if (i < cstrName.Length)
                    {
                        cstrName[i] = studentStreamReader.ReadLine();
                        cdecPercent[i] = decimal.Parse(studentStreamReader.ReadLine());
                        i++;  //Increment subscript by one
                    }
                    else
                    {
                        MessageBox.Show
                            ("Error: Notify Programmer Array Size Exceeded. ",
                            "Array Size Exceeded", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        break; //Get of out of loop; Arrays are full.
                    }//End If
                }//End Loop

                studentFile.Close();      //Close file
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Opening File. Data not loaded " + ex.Message,
                     "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cintNumberOfStudents = i;    //Save how many students were loaded
            assignLetterGrade();         //assign Letter Grade
            displayArrays();             //display arrays in list boxes
            btnLoadArrays.Enabled = false;  //Load array only once
        }


        void assignLetterGrade()
        {
            int s;
            int g;

            //Use cintNumberOfStudents to process a partially filled array
            //cintNumberOfStudents is like Length, so we need to subtract one
            //to get the subscript value of the last entry.

            //outer loop walks through students
            //inner loop looks up letter grade 

            for (s = 0; s < cintNumberOfStudents; s++)
            {
                for (g = 0; g <= cdecPERCENT_RANGE.GetUpperBound(0); g++)
                {
                    if (cdecPercent[s] >= cdecPERCENT_RANGE[g])
                    {
                        cstrGrade[s] = cstrLETTER_GRADE[g];
                        break; //exit inner for loop
                    }
                }//next g - percentage
            }//next s - student
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

            lstName.Items.Clear();
            lstPercent.Items.Clear();
            lstGrade.Items.Clear();

            //Use cintNumberOfStudents to process a partially filled array
            //cintNumberOfStudents is like Length, so we need to subtract one
            //to get the subscript value of the last entry.

            for (i = 0; i < cintNumberOfStudents; i++)
            {
                lstName.Items.Add(cstrName[i]);
                lstPercent.Items.Add(cdecPercent[i].ToString("N0")); //N-zero
                lstGrade.Items.Add(cstrGrade[i]);
            }//next i - student
        }


        private void btnSortByName_Click(object sender, EventArgs e)
        {
            //Activate code below to test bubble sort
            //bubbleSortName()
            //return; 

            //Sort by name using a Simple Selection sort
            int i;
            int i2;
            string strMinName;
            int intMinSubscript;

            //outer loop keeps track of where the next value
            //should be placed.
            for (i = 0; i < cintNumberOfStudents - 1; i++)
            {
                intMinSubscript = i;
                strMinName = cstrName[i];

                //inner loop finds the lowest value to move up
                for (i2 = i + 1; i2 < cintNumberOfStudents; i2++)
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


        void swapArrayValues(int i, int intMinSubscript)
        {
            //With parallel arrays, all corresponding data must be
            //swapped across arrays so that all associated data 
            //stays on the same row.

            string strHoldValue;
            decimal decHoldValue;

            strHoldValue = cstrName[i];
            cstrName[i] = cstrName[intMinSubscript];
            cstrName[intMinSubscript] = strHoldValue;

            decHoldValue = cdecPercent[i];
            cdecPercent[i] = cdecPercent[intMinSubscript];
            cdecPercent[intMinSubscript] = decHoldValue;

            strHoldValue = cstrGrade[i];
            cstrGrade[i] = cstrGrade[intMinSubscript];
            cstrGrade[intMinSubscript] = strHoldValue;
        }


        private void btnSortByPercent_Click(object sender, EventArgs e)
        {
            //Sort by percent using a Simple Selection sort
            int i;
            int i2;
            decimal decMinPercent;
            int intMinSubscript;

            //outer loop keeps track of where the next value
            //should be placed.
            for (i = 0; i < cintNumberOfStudents - 1; i++)
            {
                intMinSubscript = i;
                decMinPercent = cdecPercent[i];

                //inner loop finds the lowest value to move up
                for (i2 = i + 1; i2 < cintNumberOfStudents; i2++)
                {
                    //CompareTo is NOT used with numbers
                    if (cdecPercent[i2] < decMinPercent)
                    {
                        //save the new low value found
                        decMinPercent = cdecPercent[i2];
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
            //Early exit - an early exit from a search can occur when we know that
            //the value we are looking for will not be found in the array.  To
            //implement an early exit, the array most be sorted ascending.
            //If we can determine that a value will not be found, we should
            //not search the remainder of the array.

            int i;
            bool blnNameFound = false;

            //array must be sorted ascending for early exit logic to work
            btnSortByName_Click(sender, e);

            //Clear message box
            searchResultsTextBox.Clear();

            for (i = 0; i < cintNumberOfStudents; i++)
            {
                if (searchNameTextBox.Text.ToUpper() == cstrName[i].ToUpper())
                {
                    blnNameFound = true;
                    searchResultsTextBox.Text = "Matching name is selected in list box.";
                    lstName.SelectedIndex = i;
                    lstPercent.SelectedIndex = i;
                    lstGrade.SelectedIndex = i;
                    break; //exit for loop
                }
                else if (searchNameTextBox.Text.ToUpper().CompareTo(cstrName[i].ToUpper()) < 0)
                {
                    searchResultsTextBox.Text = "Match not found - Early Exit taken";
                    break; //exit for loop
                }//end if
            }//next i

            if (blnNameFound == false
            && searchResultsTextBox.Text == "")
                searchResultsTextBox.Text = "Match not found - Reached end of array";
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }//end of class
}//end of namespace