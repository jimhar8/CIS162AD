namespace CS11
{
    partial class CS10Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS10Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBookListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.mnuFilePrintPreview_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookToolStripMenuItem,
            this.removeBookToolStripMenuItem,
            this.clearBookListToolStripMenuItem,
            this.displayBookListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addBookToolStripMenuItem.Text = "&Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.mnuEditAdd_Click);
            // 
            // removeBookToolStripMenuItem
            // 
            this.removeBookToolStripMenuItem.Name = "removeBookToolStripMenuItem";
            this.removeBookToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.removeBookToolStripMenuItem.Text = "&Remove Book";
            this.removeBookToolStripMenuItem.Click += new System.EventHandler(this.mnuEditRemove_Click);
            // 
            // clearBookListToolStripMenuItem
            // 
            this.clearBookListToolStripMenuItem.Name = "clearBookListToolStripMenuItem";
            this.clearBookListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.clearBookListToolStripMenuItem.Text = "&Clear Book List";
            this.clearBookListToolStripMenuItem.Click += new System.EventHandler(this.mnuEditClear_Click);
            // 
            // displayBookListToolStripMenuItem
            // 
            this.displayBookListToolStripMenuItem.Name = "displayBookListToolStripMenuItem";
            this.displayBookListToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.displayBookListToolStripMenuItem.Text = "&Display Book List";
            this.displayBookListToolStripMenuItem.Click += new System.EventHandler(this.mnuEditDisplay_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.mnuHelpAboutForm_Click);
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
            this.cboBook.Items.AddRange(new object[] {
            "How to Program",
            "Introduction to Programming",
            "Object-Oriented Programming",
            "Problem Solving and Programming",
            "Program Design and Data Structures"});
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
            // CS10aForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 262);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.cboBook);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CS10aForm";
            this.Text = "CS10 by Jim Harris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearBookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBookListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox cboBook;
        public System.Windows.Forms.Label lblComboBox;
    }
}

