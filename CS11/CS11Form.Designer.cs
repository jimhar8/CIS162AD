namespace CS11
{
    partial class CS11Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS11Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileLoadBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDisplayBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilePrintPreview,
            this.mnuFilePrint,
            this.mnuFileLoadBooks,
            this.mnuFileSaveBooks,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFilePrintPreview
            // 
            this.mnuFilePrintPreview.Name = "mnuFilePrintPreview";
            this.mnuFilePrintPreview.Size = new System.Drawing.Size(152, 22);
            this.mnuFilePrintPreview.Text = "Print Pre&view";
            this.mnuFilePrintPreview.Click += new System.EventHandler(this.mnuFilePrintPreview_Click);
            // 
            // mnuFilePrint
            // 
            this.mnuFilePrint.Name = "mnuFilePrint";
            this.mnuFilePrint.Size = new System.Drawing.Size(152, 22);
            this.mnuFilePrint.Text = "&Print Books";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // mnuFileLoadBooks
            // 
            this.mnuFileLoadBooks.Name = "mnuFileLoadBooks";
            this.mnuFileLoadBooks.Size = new System.Drawing.Size(152, 22);
            this.mnuFileLoadBooks.Text = "&Load Books";
            this.mnuFileLoadBooks.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // mnuFileSaveBooks
            // 
            this.mnuFileSaveBooks.Name = "mnuFileSaveBooks";
            this.mnuFileSaveBooks.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveBooks.Text = "&Save Books";
            this.mnuFileSaveBooks.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAddBook,
            this.mnuEditRemoveBook,
            this.mnuEditClearList,
            this.mnuEditDisplayBook});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditAddBook
            // 
            this.mnuEditAddBook.Name = "mnuEditAddBook";
            this.mnuEditAddBook.Size = new System.Drawing.Size(163, 22);
            this.mnuEditAddBook.Text = "&Add Book";
            this.mnuEditAddBook.Click += new System.EventHandler(this.mnuEditAdd_Click);
            // 
            // mnuEditRemoveBook
            // 
            this.mnuEditRemoveBook.Name = "mnuEditRemoveBook";
            this.mnuEditRemoveBook.Size = new System.Drawing.Size(163, 22);
            this.mnuEditRemoveBook.Text = "&Remove Book";
            this.mnuEditRemoveBook.Click += new System.EventHandler(this.mnuEditRemove_Click);
            // 
            // mnuEditClearList
            // 
            this.mnuEditClearList.Name = "mnuEditClearList";
            this.mnuEditClearList.Size = new System.Drawing.Size(163, 22);
            this.mnuEditClearList.Text = "&Clear Book List";
            this.mnuEditClearList.Click += new System.EventHandler(this.mnuEditClear_Click);
            // 
            // mnuEditDisplayBook
            // 
            this.mnuEditDisplayBook.Name = "mnuEditDisplayBook";
            this.mnuEditDisplayBook.Size = new System.Drawing.Size(163, 22);
            this.mnuEditDisplayBook.Text = "&Display Book List";
            this.mnuEditDisplayBook.Click += new System.EventHandler(this.mnuEditDisplay_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAboutForm_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cboBook
            // 
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(21, 103);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(312, 21);
            this.cboBook.TabIndex = 1;
            // 
            // lblComboBox
            // 
            this.lblComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.lblComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblComboBox.Location = new System.Drawing.Point(18, 75);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblComboBox.Size = new System.Drawing.Size(112, 16);
            this.lblComboBox.TabIndex = 2;
            this.lblComboBox.Text = "Book List:";
            // 
            // CS11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.cboBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CS11Form";
            this.Text = "CS11 by Jim Harris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCS11_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAddBook;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuEditClearList;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDisplayBook;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cboBook;
        public System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoadBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveBooks;
    }
}

