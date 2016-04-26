namespace CS12ex
{
    partial class frmCS12ex
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
            this.btnExit = new System.Windows.Forms.Button();
            this.searchResultsTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSortByPercent = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnLoadArrays = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstGrade = new System.Windows.Forms.ListBox();
            this.lstPercent = new System.Windows.Forms.ListBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(138, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 24);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // searchResultsTextBox
            // 
            this.searchResultsTextBox.Enabled = false;
            this.searchResultsTextBox.Location = new System.Drawing.Point(114, 289);
            this.searchResultsTextBox.Name = "searchResultsTextBox";
            this.searchResultsTextBox.ReadOnly = true;
            this.searchResultsTextBox.Size = new System.Drawing.Size(208, 20);
            this.searchResultsTextBox.TabIndex = 44;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(10, 289);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Search Results:";
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(114, 249);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.searchNameTextBox.TabIndex = 42;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(10, 249);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 23);
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Search Name:";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(250, 207);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(72, 34);
            this.btnSearchByName.TabIndex = 40;
            this.btnSearchByName.Text = "Search by Name";
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSortByPercent
            // 
            this.btnSortByPercent.Location = new System.Drawing.Point(170, 207);
            this.btnSortByPercent.Name = "btnSortByPercent";
            this.btnSortByPercent.Size = new System.Drawing.Size(64, 34);
            this.btnSortByPercent.TabIndex = 39;
            this.btnSortByPercent.Text = "Sort by Percent";
            this.btnSortByPercent.Click += new System.EventHandler(this.btnSortByPercent_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(90, 207);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(72, 34);
            this.btnSortByName.TabIndex = 38;
            this.btnSortByName.Text = "Sort by Name";
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnLoadArrays
            // 
            this.btnLoadArrays.Location = new System.Drawing.Point(10, 207);
            this.btnLoadArrays.Name = "btnLoadArrays";
            this.btnLoadArrays.Size = new System.Drawing.Size(72, 34);
            this.btnLoadArrays.TabIndex = 37;
            this.btnLoadArrays.Text = "Load Arrays";
            this.btnLoadArrays.Click += new System.EventHandler(this.btnLoadArrays_Click);
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(258, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 16);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "Grade:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(178, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 16);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Percent:";
            // 
            // lstGrade
            // 
            this.lstGrade.Enabled = false;
            this.lstGrade.Location = new System.Drawing.Point(258, 41);
            this.lstGrade.Name = "lstGrade";
            this.lstGrade.Size = new System.Drawing.Size(56, 147);
            this.lstGrade.TabIndex = 34;
            // 
            // lstPercent
            // 
            this.lstPercent.Enabled = false;
            this.lstPercent.Location = new System.Drawing.Point(178, 41);
            this.lstPercent.Name = "lstPercent";
            this.lstPercent.Size = new System.Drawing.Size(56, 147);
            this.lstPercent.TabIndex = 33;
            this.lstPercent.TabStop = false;
            // 
            // lstName
            // 
            this.lstName.Enabled = false;
            this.lstName.Location = new System.Drawing.Point(10, 41);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(144, 147);
            this.lstName.TabIndex = 32;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Student Name:";
            // 
            // frmCS12ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.searchResultsTextBox);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSortByPercent);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnLoadArrays);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lstGrade);
            this.Controls.Add(this.lstPercent);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.Label1);
            this.Name = "frmCS12ex";
            this.Text = "CS12ex Your Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox searchResultsTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox searchNameTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnSearchByName;
        internal System.Windows.Forms.Button btnSortByPercent;
        internal System.Windows.Forms.Button btnSortByName;
        internal System.Windows.Forms.Button btnLoadArrays;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox lstGrade;
        internal System.Windows.Forms.ListBox lstPercent;
        internal System.Windows.Forms.ListBox lstName;
        internal System.Windows.Forms.Label Label1;
    }
}

