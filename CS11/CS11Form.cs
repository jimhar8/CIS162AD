using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 CS11 Jim Harris
 Maintain a list of books; 
 Users can Add and Remove books, or clear entire list.
 The list can also be printed.
 
*/

namespace CS11
{
    public partial class CS11Form : Form
    {
        private bool cblnIsDataSaved = true;

        public CS11Form()
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

                cblnIsDataSaved = false;
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
                cblnIsDataSaved = false;
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
                cblnIsDataSaved = false;
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

        private void mnuFileLoad_Click(object sender, EventArgs e)
        {

            string strFileName;
            string strBookName;

            //Open the file and load the list box with the data stored in the file
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1; // At first only show text files.
                openFileDialog1.InitialDirectory = Application.StartupPath; //default folder
                openFileDialog1.RestoreDirectory = true;  // restore path to default folder

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strFileName = openFileDialog1.FileName;
                    FileStream booksFileIn = new FileStream(strFileName, FileMode.Open);
                    StreamReader booksStreamReader = new StreamReader(booksFileIn);
                    while (booksStreamReader.Peek() != -1)
                    {
                        strBookName = booksStreamReader.ReadLine();
                        cboBook.Items.Add(strBookName);
                    }
                    booksStreamReader.Close();
                }
                else
                {
                    MessageBox.Show("File not selected; List was not loaded.",
                            "List Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Selected file could not be opened.",
                        "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {

            string strFileName;
            int intIndex, intMaximum;
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1; // At first only show text files.
                saveFileDialog1.CheckFileExists = false; // Allow user to create file
                saveFileDialog1.InitialDirectory = Application.StartupPath; //default folder
                saveFileDialog1.RestoreDirectory = true;  // restore path to default folder

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strFileName = saveFileDialog1.FileName;
                    FileStream booksFileOut = new FileStream(strFileName, FileMode.Create);
                    StreamWriter booksStreamWriter = new StreamWriter(booksFileOut);

                    intMaximum = cboBook.Items.Count;
                    for (intIndex = 0; intIndex < intMaximum; intIndex++)
                    {
                        booksStreamWriter.WriteLine(cboBook.Items[intIndex]);
                    }
                    booksStreamWriter.Close();
                    cblnIsDataSaved = true;  //reset flag after saving data
                }
            }
            catch
            {
                MessageBox.Show("Error saving the changes to the data file.",
                        "Error Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCS11_FormClosing(object sender, FormClosingEventArgs e)
        {
            //After writing this method to handle the FormClosing event, its needs to
            //be assigned as the form's FormClosing event handler while in Design Mode.
            //After assigning it to the form, the method is automatically executed 
            //when the form is instructed to close.

            //If changes have not been saved, ask user if they want to save the changes

            DialogResult responseDialogResult;

            if (cblnIsDataSaved == false)
            {
                responseDialogResult = MessageBox.Show("Book list has changed. Save the list?",
                        "Book List Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    mnuFileSave_Click(mnuFileSaveBooks, new System.EventArgs());
                }
                if (responseDialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; //cancel close event
                }
            }
        }




    }
}
