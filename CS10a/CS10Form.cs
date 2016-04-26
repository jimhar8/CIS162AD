using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 CS10a Jim Harris
 Maintain a list of books; 
 Users can Add and Remove books, or clear entire list.
 The list can also be printed.
 
*/

namespace CS11
{
    public partial class CS10Form : Form
    {
        public CS10Form()
        {
            InitializeComponent();
        }

        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            //Add a new book
            if (cboBook.Text != "")
            {
                cboBook.Items.Add(cboBook.Text);
                cboBook.Text = "";
            }
            else
            {
                MessageBox.Show("Enter a book to add", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cboBook.Focus();
        }

        private void mnuEditRemove_Click(object sender, EventArgs e)
        {

            //Remove the book from list
            if (cboBook.SelectedIndex != -1)
            {
                cboBook.Items.RemoveAt(cboBook.SelectedIndex);
            }
            else
            {
                MessageBox.Show("First select book to remove",
                    "No selection made", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void mnuEditClear_Click(object sender, EventArgs e)
        {

            //Clear the book collection
            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Clear the book list?",
                "Clear book list", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (responseDialogResult == DialogResult.Yes)
            {
                cboBook.Items.Clear();
            }

        }

        private void mnuEditDisplay_Click(object sender, EventArgs e)
        {
            int numItems = 0;

            numItems = cboBook.Items.Count;

            MessageBox.Show("The number of book types is " + numItems.ToString());



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //  Handle printing and print previews
            //  printPreviewDialog1.ShowDialog() and printDocument1.Print() trigger
            //  PrintPage event.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float fltLineHeight = printFont.GetHeight();
            float fltPrintX = e.MarginBounds.Left;
            float fltPrintY = e.MarginBounds.Top;
            string strPrintLine;

            //Print Headings
            strPrintLine = "Book List ";
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);
            strPrintLine = "Programmer: Jim Harris";
            fltPrintY += fltLineHeight;
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);
            strPrintLine = "Books:";
            fltPrintY += fltLineHeight;
            e.Graphics.DrawString(strPrintLine, headingFont,
                Brushes.Black, fltPrintX, fltPrintY);

            //Leave a blank line between heading and detail line
            fltPrintY += fltLineHeight * 2;

            //Loop through the entire list
            for (int intIndex = 0; intIndex <= cboBook.Items.Count - 1; intIndex++)
            {
                //Set up a line
                strPrintLine = cboBook.Items[intIndex].ToString();
                //Send the line to the graphics page object
                e.Graphics.DrawString(strPrintLine, printFont,
                    Brushes.Black, fltPrintX, fltPrintY);

                //Increment the Y position for the next line
                fltPrintY += fltLineHeight;
            }

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuHelpAboutForm_Click(object sender, EventArgs e)
        {

            //Create an instance and display AboutForm 
            frmAbout frmAboutObj = new frmAbout();
            frmAboutObj.ShowDialog();   //.ShowDialog displays as a Modal Form

        }




    }
}
