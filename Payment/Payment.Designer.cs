namespace Payment
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.gbBilling = new System.Windows.Forms.GroupBox();
            this.rbBillCustomer = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.lboxCreditCardType = new System.Windows.Forms.ListBox();
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.cbExpYear = new System.Windows.Forms.ComboBox();
            this.cbExpMonth = new System.Windows.Forms.ComboBox();
            this.cbSetDefaultBillMethod = new System.Windows.Forms.CheckBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbCardType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbExpDate = new System.Windows.Forms.Label();
            this.gbBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBilling
            // 
            this.gbBilling.Controls.Add(this.rbBillCustomer);
            this.gbBilling.Controls.Add(this.rbCreditCard);
            this.gbBilling.Location = new System.Drawing.Point(43, 20);
            this.gbBilling.Name = "gbBilling";
            this.gbBilling.Size = new System.Drawing.Size(478, 91);
            this.gbBilling.TabIndex = 0;
            this.gbBilling.TabStop = false;
            this.gbBilling.Text = "Billing";
            // 
            // rbBillCustomer
            // 
            this.rbBillCustomer.AutoSize = true;
            this.rbBillCustomer.Location = new System.Drawing.Point(298, 35);
            this.rbBillCustomer.Name = "rbBillCustomer";
            this.rbBillCustomer.Size = new System.Drawing.Size(174, 33);
            this.rbBillCustomer.TabIndex = 1;
            this.rbBillCustomer.TabStop = true;
            this.rbBillCustomer.Text = "Bill Customer";
            this.rbBillCustomer.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(55, 35);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(156, 33);
            this.rbCreditCard.TabIndex = 0;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // lboxCreditCardType
            // 
            this.lboxCreditCardType.FormattingEnabled = true;
            this.lboxCreditCardType.ItemHeight = 29;
            this.lboxCreditCardType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "Chase",
            "American Express",
            "Discover"});
            this.lboxCreditCardType.Location = new System.Drawing.Point(236, 155);
            this.lboxCreditCardType.Name = "lboxCreditCardType";
            this.lboxCreditCardType.Size = new System.Drawing.Size(285, 149);
            this.lboxCreditCardType.TabIndex = 1;
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(236, 336);
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(285, 37);
            this.tbCardNumber.TabIndex = 2;
            // 
            // cbExpYear
            // 
            this.cbExpYear.FormattingEnabled = true;
            this.cbExpYear.Location = new System.Drawing.Point(408, 428);
            this.cbExpYear.Name = "cbExpYear";
            this.cbExpYear.Size = new System.Drawing.Size(113, 37);
            this.cbExpYear.TabIndex = 3;
            this.cbExpYear.Text = "Year";
            // 
            // cbExpMonth
            // 
            this.cbExpMonth.FormattingEnabled = true;
            this.cbExpMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbExpMonth.Location = new System.Drawing.Point(236, 428);
            this.cbExpMonth.Name = "cbExpMonth";
            this.cbExpMonth.Size = new System.Drawing.Size(113, 37);
            this.cbExpMonth.TabIndex = 4;
            this.cbExpMonth.Text = "Month";
            // 
            // cbSetDefaultBillMethod
            // 
            this.cbSetDefaultBillMethod.AutoSize = true;
            this.cbSetDefaultBillMethod.Location = new System.Drawing.Point(52, 513);
            this.cbSetDefaultBillMethod.Name = "cbSetDefaultBillMethod";
            this.cbSetDefaultBillMethod.Size = new System.Drawing.Size(327, 33);
            this.cbSetDefaultBillMethod.TabIndex = 5;
            this.cbSetDefaultBillMethod.Text = "Set as default billing method.";
            this.cbSetDefaultBillMethod.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(239, 581);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(110, 41);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(411, 581);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(110, 41);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbCardType
            // 
            this.lbCardType.AutoSize = true;
            this.lbCardType.Location = new System.Drawing.Point(37, 155);
            this.lbCardType.Name = "lbCardType";
            this.lbCardType.Size = new System.Drawing.Size(193, 29);
            this.lbCardType.TabIndex = 8;
            this.lbCardType.Text = "Credit Card Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card Number:";
            // 
            // lbExpDate
            // 
            this.lbExpDate.AutoSize = true;
            this.lbExpDate.Location = new System.Drawing.Point(37, 436);
            this.lbExpDate.Name = "lbExpDate";
            this.lbExpDate.Size = new System.Drawing.Size(173, 29);
            this.lbExpDate.TabIndex = 10;
            this.lbExpDate.Text = "Expiration Date:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 648);
            this.Controls.Add(this.lbExpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCardType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.cbSetDefaultBillMethod);
            this.Controls.Add(this.cbExpMonth);
            this.Controls.Add(this.cbExpYear);
            this.Controls.Add(this.tbCardNumber);
            this.Controls.Add(this.lboxCreditCardType);
            this.Controls.Add(this.gbBilling);
            this.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.gbBilling.ResumeLayout(false);
            this.gbBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBilling;
        private System.Windows.Forms.RadioButton rbBillCustomer;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.ListBox lboxCreditCardType;
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.ComboBox cbExpYear;
        private System.Windows.Forms.ComboBox cbExpMonth;
        private System.Windows.Forms.CheckBox cbSetDefaultBillMethod;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbCardType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbExpDate;
    }
}