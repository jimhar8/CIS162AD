using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

//CS10b by Jim Harris

namespace CS11
{
    public partial class frmCS10b : Form
    {
        public frmCS10b()
        {
            InitializeComponent();
        }


        private void btnWhileLoop_Click(object sender, EventArgs e)
        {
            int r = 0; //row
            int c = 0; //column
            int intResult;
            string strSpace;

            txtTable.Clear();    //clear the text box
            txtTable.Refresh();  //refresh the form before exiting the method
            Thread.Sleep(1000);  //wait one second to see the clear text box

            //Outer loop goes down the rows
            r = 1;   //initialize r
            while (r < 10)
            {
                //Inner loop goes across the columns
                c = 1;    //initialize c
                while (c < 10)
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                    c++;  //increment c
                }

                txtTable.AppendText("\r\n");  //Move down one line
                r++;  //increment r
            }
        }


        //Modify the nested while loops used above to nested do-while loops
        private void btnDoWhileLoop_Click(object sender, EventArgs e)
        {
            int r = 0; //row
            int c = 0; //column
            int intResult;
            string strSpace;

            txtTable.Clear();    //clear the text box
            txtTable.Refresh();  //refresh the form before exiting the method
            Thread.Sleep(1000);  //wait one second to see the clear text box

            //Outer loop goes down the rows
            r = 1;
            do
            {
                //Inner loop goes across the columns
                c = 1;
                do
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                    c++;
                } while (c < 10);

                txtTable.AppendText("\r\n");  //Move down one line
                r++;
            } while (r < 10);
        }


        //Modify the nested while loops used above to nested for loops
        private void btnForLoop_Click(object sender, EventArgs e)
        {
            int r = 0; //row
            int c = 0; //column
            int intResult;
            string strSpace;

            txtTable.Clear();    //clear the text box
            txtTable.Refresh();  //refresh the form before exiting the method
            Thread.Sleep(1000);  //wait one second to see the clear text box

              //Outer loop goes down the rows
            for (r = 1; r < 10; r++)
            {
                //Inner loop goes across the columns
                for (c = 1; c < 10; c++)
                {
                    intResult = r * c;

                    if (intResult < 10)
                        strSpace = "  ";  //two spaces 
                    else
                        strSpace = " ";   //one space
                    txtTable.AppendText(strSpace); // insert space

                    txtTable.AppendText(intResult.ToString());  //insert result
                }

                txtTable.AppendText("\r\n");  //Move down one line
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }//end of form
}//end of namespace