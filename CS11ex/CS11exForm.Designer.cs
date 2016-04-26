namespace CS11ex
{
    partial class frmCS11ex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCS11ex));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cboCoffee = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // cboCoffee
            // 
            this.cboCoffee.BackColor = System.Drawing.SystemColors.Window;
            this.cboCoffee.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboCoffee.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCoffee.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCoffee.Location = new System.Drawing.Point(23, 97);
            this.cboCoffee.Name = "cboCoffee";
            this.cboCoffee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCoffee.Size = new System.Drawing.Size(138, 22);
            this.cboCoffee.Sorted = true;
            this.cboCoffee.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(23, 65);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(112, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "&Coffee Flavors:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilePrintPreview,
            this.mnuFilePrint,
            this.toolStripMenuItem1,
            this.mnuFileLoad,
            this.mnuFileSave,
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
            this.mnuFilePrint.Text = "&Print";
            this.mnuFilePrint.Click += new System.EventHandler(this.mnuFilePrint_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileLoad
            // 
            this.mnuFileLoad.Name = "mnuFileLoad";
            this.mnuFileLoad.Size = new System.Drawing.Size(152, 22);
            this.mnuFileLoad.Text = "&Load List";
            this.mnuFileLoad.Click += new System.EventHandler(this.mnuFileLoad_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSave.Text = "&Save List";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
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
            this.mnuEditAdd,
            this.mnuEditRemove,
            this.mnuEditClear,
            this.mnuEditDisplay});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditAdd
            // 
            this.mnuEditAdd.Name = "mnuEditAdd";
            this.mnuEditAdd.Size = new System.Drawing.Size(186, 22);
            this.mnuEditAdd.Text = "&Add Coffee";
            this.mnuEditAdd.Click += new System.EventHandler(this.mnuEditAdd_Click);
            // 
            // mnuEditRemove
            // 
            this.mnuEditRemove.Name = "mnuEditRemove";
            this.mnuEditRemove.Size = new System.Drawing.Size(186, 22);
            this.mnuEditRemove.Text = "&Remove Coffee";
            this.mnuEditRemove.Click += new System.EventHandler(this.mnuEditRemove_Click);
            // 
            // mnuEditClear
            // 
            this.mnuEditClear.Name = "mnuEditClear";
            this.mnuEditClear.Size = new System.Drawing.Size(186, 22);
            this.mnuEditClear.Text = "&Clear Coffee List";
            this.mnuEditClear.Click += new System.EventHandler(this.mnuEditClear_Click);
            // 
            // mnuEditDisplay
            // 
            this.mnuEditDisplay.Name = "mnuEditDisplay";
            this.mnuEditDisplay.Size = new System.Drawing.Size(186, 22);
            this.mnuEditDisplay.Text = "&Display Coffee Count";
            this.mnuEditDisplay.Click += new System.EventHandler(this.mnuEditDisplayCount_Click);
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
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // frmCS11ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 192);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboCoffee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCS11ex";
            this.Text = "CS11ex Your Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCS11ex_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.ComboBox cboCoffee;
        public System.Windows.Forms.Label Label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePrint;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRemove;
        private System.Windows.Forms.ToolStripMenuItem mnuEditClear;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileLoad;
    }
}

