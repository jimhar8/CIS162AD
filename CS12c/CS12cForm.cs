using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//CS12c by Jim Harris
 
namespace CS12c
{
    public partial class frmCS12c : Form
    {

        int [ , ] intTable = new int[9,9];  // 9 x 9 table 
        
        public frmCS12c()
        {
            InitializeComponent();
        }

        private void btnLoadArray_Click(object sender, EventArgs e)
        {
            int r; //row
            int c; //column
            int intResult;

            for (r = 0; r <  intTable.GetLength(0) ; r++)
            {

                for (c = 0; c < intTable.GetLength(1); c++)
                {
                    intResult = (r + 1) * (c + 1);
                    intTable[r , c] = intResult;                    
                }
                
            }

        }

 
        //Modify the nested for loops used above to nested while loops
        private void btnDisplayArray_Click(object sender, EventArgs e)
        {
            int r; //row
            int c; //column
            string strSpace;
            string strText = "";

            txtTable.Clear(); //clear the text box

            for (r = 0; r < intTable.GetLength(0); r++)
            {
                for (c = 0; c < intTable.GetLength(1); c++)
                {
                    int intResult = intTable[r, c];

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space

                    txtTable.AppendText(strSpace); // insert space
                    txtTable.AppendText(intResult.ToString());  //insert result

                }

                txtTable.AppendText("\r\n");
            }

            txtTable.AppendText(strText);

        }

 
       private void btnSearchArray_Click(object sender, EventArgs e)
       {
            int r; //row
            int c; //column
            int intSearchNumber;

            txtTable.Clear(); //clear the text box            

            try
            {
                intSearchNumber = int.Parse(txtSearchNumber.Text);

                for (r = 0; r < intTable.GetLength(0); r++)
                {

                    for (c = 0; c < intTable.GetLength(1); c++)
                    {
                        if (intTable[r, c] == intSearchNumber)
                        {
                            txtTable.AppendText(intSearchNumber.ToString() + " located in " + r.ToString() + ", " + c.ToString());
                            txtTable.AppendText("\r\n");
                        }
                    }

                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error parsing", MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }//end of form
}//end of namespace