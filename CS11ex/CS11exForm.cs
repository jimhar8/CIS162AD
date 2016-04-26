using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;  //need this for FileStream, StreamReader, StreamWriter

/*
 CS11ex Juan Marquez 
 Maintain a list of coffee flavors; 
 Users can Add and Remove flavors, or clear entire list.
 The list can also be printed.
 The initial list is loaded from a file, and users
 can save their changes to a file. 
 
*/

namespace CS11ex
{
    public partial class frmCS11ex : Form
    {
//Use a flag to track if the data has been changed but not saved
//Set to true as the default; set to false when the user makes a change
        private bool cblnIsDataSaved = true;

        public frmCS11ex()
        {
            InitializeComponent();
        }

        private void mnuFileLoad_Click(object sender, EventArgs e)
        {
            //Not checking if a list has already been loaded
            string strFileName;
            string strFlavorName;

           //Open the file and load the list box with the data stored in the file
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
                openFileDialog1.FilterIndex = 1; // At first only show text files.
                openFileDialog1.InitialDirectory = Application.StartupPath; //default folder
                openFileDialog1.RestoreDirectory = true;  // restore path to default folder

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    strFileName = openFileDialog1.FileName;
                    FileStream flavorsFileIn = new FileStream(strFileName, FileMode.Open);
                    StreamReader flavorsStreamReader = new StreamReader(flavorsFileIn);
                    while (flavorsStreamReader.Peek() != -1)
                    {
                        strFlavorName = flavorsStreamReader.ReadLine();
                        cboCoffee.Items.Add(strFlavorName);
                    }
                    flavorsStreamReader.Close();
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


         private void frmCS11ex_FormClosing(object sender, FormClosingEventArgs e)
        {
            //After writing this method to handle the FormClosing event, its needs to
            //be assigned as the form's FormClosing event handler while in Design Mode.
            //After assigning it to the form, the method is automatically executed 
            //when the form is instructed to close.

            //If changes have not been saved, ask user if they want to save the changes

            DialogResult responseDialogResult;

            if (cblnIsDataSaved == false)
            {
                responseDialogResult = MessageBox.Show("Coffee list has changed. Save the list?",
                        "Coffee List Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    mnuFileSave_Click(mnuFileSave, new System.EventArgs());
                }
                if (responseDialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true; //cancel close event
                }
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
                    FileStream flavorsFileOut = new FileStream(strFileName, FileMode.Create);
                    StreamWriter flavorsStreamWriter = new StreamWriter(flavorsFileOut);

                    intMaximum = cboCoffee.Items.Count;
                    for (intIndex = 0; intIndex < intMaximum; intIndex++)
                    {
                        flavorsStreamWriter.WriteLine(cboCoffee.Items[intIndex]);
                    }
                    flavorsStreamWriter.Close();
                    cblnIsDataSaved = true;  //reset flag after saving data
                }
            }
            catch
            {
                MessageBox.Show("Error saving the changes to the data file.",
                        "Error Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


//Set cblnIsDataSaved = false when list is changed.
//However, the statement is inside the if statements because
//that's when we know changes have been succesfully made.
        private void mnuEditAdd_Click(object sender, EventArgs e)
        {
            //Add a new coffee flavor to the coffee list
            if (cboCoffee.Text != "")
            {
                cboCoffee.Items.Add(cboCoffee.Text);
                cboCoffee.Text = "";
                cblnIsDataSaved = false;
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
                cblnIsDataSaved = false;
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
                cblnIsDataSaved = false;
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
            frmAboutObj.Show();
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
    }
}