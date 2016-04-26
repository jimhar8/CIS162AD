namespace CS2
{
    partial class frmCS2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnOrderProcessing = new System.Windows.Forms.Button();
            this.btnMarketing = new System.Windows.Forms.Button();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(155, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(81, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(81, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartment.Location = new System.Drawing.Point(189, 85);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(200, 22);
            this.lblDepartment.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblContact.Location = new System.Drawing.Point(189, 114);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(200, 22);
            this.lblContact.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPhone.Location = new System.Drawing.Point(189, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(200, 22);
            this.lblPhone.TabIndex = 6;
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoSize = true;
            this.btnCustomer.Location = new System.Drawing.Point(102, 218);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(108, 23);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "&Customer Relations";
            this.toolTip1.SetToolTip(this.btnCustomer, "Displays the contact information for the customer relations department");
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustRelations_Click);
            // 
            // btnOrderProcessing
            // 
            this.btnOrderProcessing.Location = new System.Drawing.Point(102, 247);
            this.btnOrderProcessing.Name = "btnOrderProcessing";
            this.btnOrderProcessing.Size = new System.Drawing.Size(108, 23);
            this.btnOrderProcessing.TabIndex = 9;
            this.btnOrderProcessing.Text = "&Order Processing";
            this.toolTip1.SetToolTip(this.btnOrderProcessing, "Displays the order processing department");
            this.btnOrderProcessing.UseVisualStyleBackColor = true;
            this.btnOrderProcessing.Click += new System.EventHandler(this.btnOrderProcessing_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.AutoSize = true;
            this.btnMarketing.Location = new System.Drawing.Point(226, 218);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Size = new System.Drawing.Size(64, 23);
            this.btnMarketing.TabIndex = 8;
            this.btnMarketing.Text = "&Marketing";
            this.toolTip1.SetToolTip(this.btnMarketing, "Displays the contact information for the marketing department");
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnShipping
            // 
            this.btnShipping.Location = new System.Drawing.Point(226, 247);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(64, 23);
            this.btnShipping.TabIndex = 10;
            this.btnShipping.Text = "&Shipping";
            this.toolTip1.SetToolTip(this.btnShipping, "Displays the contact information for the shipping department");
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits the application");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCS2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 320);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.btnMarketing);
            this.Controls.Add(this.btnOrderProcessing);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCS2";
            this.Text = "CS2 by Jim Harris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnOrderProcessing;
        private System.Windows.Forms.Button btnMarketing;
        private System.Windows.Forms.Button btnShipping;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

