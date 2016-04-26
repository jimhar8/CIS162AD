using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/*
 CS10ex Juan Marquez 
 Maintain a list of coffee flavors; 
 Users can Add and Remove flavors, or clear entire list.
 The list can also be printed.
 
*/

namespace CS10ex
{
    public partial class frmCS10ex : Form
    {
        public frmCS10ex()
        {
            InitializeComponent();
        }

        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            //Add a new coffee flavor to the coffee list
            if (cboCoffee.Text != "")
            {
                cboCoffee.Items.Add(cboCoffee.Text);
                cboCoffee.Text = "";
            }
            else
            {
                MessageBox.Show("Enter a coffee flavor to add", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cboCoffee.Focus();
        }

        private void mnuEditRemove_Click(object sender, EventArgs e)
        {
            //Remove the selected coffee from list
            if (cboCoffee.SelectedIndex != -1)
            {
                cboCoffee.Items.RemoveAt(cboCoffee.SelectedIndex);
            }
            else
            {
                MessageBox.Show("First select the coffee to remove",
                    "No selection made", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuEditClear_Click(object sender, EventArgs e)
        {
            //Clear the coffee list
            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Clear the coffee flavor list?",
                "Clear coffee list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (responseDialogResult == DialogResult.Yes)
            {
                cboCoffee.Items.Clear();
            }
        }

        private void mnuEditDisplayCount_Click(object sender, EventArgs e)
        {
            //Display a count of the coffees in list
            MessageBox.Show("The number of coffee types is " + cboCoffee.Items.Count.ToString());
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            //Create an instance and display AboutForm 
            frmAbout frmAboutObj = new frmAbout();
            frmAboutObj.ShowDialog();   //.ShowDialog displays as a Modal Form
        }

        private void mnuFilePrintPreview_Click(object sender, EventArgs e)
        {
            //Begin print preview by assigning PrintDocument
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            //Trigger the print process by calling the Print method
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, 
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Handle printing and print previews
            //printPreviewDialog1.ShowDialog() and printDocument1.Print() trigger
            //  PrintPage event.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float fltLineHeight = printFont.GetHeight();
            float fltPrintX = e.MarginBounds.Left;
            float fltPrintY = e.MarginBounds.Top;
            string strPrintLine;

            //Print Headings
            strPrintLine = "Coffee List ";
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);
            strPrintLine = "by Programmer Name";
            fltPrintY += fltLineHeight;
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);

            //Leave a blank line between heading and detail line
            fltPrintY += fltLineHeight * 2;

            //Loop through the entire list
            for (int intIndex = 0; intIndex <= cboCoffee.Items.Count - 1; intIndex++)
            {
                //Set up a line
                strPrintLine = cboCoffee.Items[intIndex].ToString();
                //Send the line to the graphics page object
                e.Graphics.DrawString(strPrintLine, printFont,
                    Brushes.Black, fltPrintX, fltPrintY);

                //Increment the Y position for the next line
                fltPrintY += fltLineHeight;
            }
        }		
		
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

    }
}