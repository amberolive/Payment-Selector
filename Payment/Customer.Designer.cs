namespace Payment
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.lbCustName = new System.Windows.Forms.Label();
            this.lbPaymentMethod = new System.Windows.Forms.Label();
            this.displayPaymentMethod = new System.Windows.Forms.Label();
            this.btSelectPayment = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbCustNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCustName
            // 
            this.lbCustName.AutoSize = true;
            this.lbCustName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustName.Location = new System.Drawing.Point(46, 43);
            this.lbCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustName.Name = "lbCustName";
            this.lbCustName.Size = new System.Drawing.Size(194, 32);
            this.lbCustName.TabIndex = 0;
            this.lbCustName.Text = "Customer Name:";
            // 
            // lbPaymentMethod
            // 
            this.lbPaymentMethod.AutoSize = true;
            this.lbPaymentMethod.Location = new System.Drawing.Point(37, 128);
            this.lbPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaymentMethod.Name = "lbPaymentMethod";
            this.lbPaymentMethod.Size = new System.Drawing.Size(203, 32);
            this.lbPaymentMethod.TabIndex = 1;
            this.lbPaymentMethod.Text = "Payment Method:";
            // 
            // displayPaymentMethod
            // 
            this.displayPaymentMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayPaymentMethod.Location = new System.Drawing.Point(46, 171);
            this.displayPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayPaymentMethod.Name = "displayPaymentMethod";
            this.displayPaymentMethod.Size = new System.Drawing.Size(306, 199);
            this.displayPaymentMethod.TabIndex = 2;
            // 
            // btSelectPayment
            // 
            this.btSelectPayment.Location = new System.Drawing.Point(462, 128);
            this.btSelectPayment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSelectPayment.Name = "btSelectPayment";
            this.btSelectPayment.Size = new System.Drawing.Size(196, 45);
            this.btSelectPayment.TabIndex = 3;
            this.btSelectPayment.Text = "Select/Change Payment";
            this.btSelectPayment.UseVisualStyleBackColor = true;
            this.btSelectPayment.Click += new System.EventHandler(this.btSelectPayment_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(394, 332);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 38);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(546, 332);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 38);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbCustNames
            // 
            this.cbCustNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustNames.FormattingEnabled = true;
            this.cbCustNames.Location = new System.Drawing.Point(256, 40);
            this.cbCustNames.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbCustNames.Name = "cbCustNames";
            this.cbCustNames.Size = new System.Drawing.Size(217, 40);
            this.cbCustNames.TabIndex = 6;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 411);
            this.Controls.Add(this.cbCustNames);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSelectPayment);
            this.Controls.Add(this.displayPaymentMethod);
            this.Controls.Add(this.lbPaymentMethod);
            this.Controls.Add(this.lbCustName);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustName;
        private System.Windows.Forms.Label lbPaymentMethod;
        private System.Windows.Forms.Label displayPaymentMethod;
        private System.Windows.Forms.Button btSelectPayment;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbCustNames;
    }
}

