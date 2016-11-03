using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        // Populates expiration year combobox with the current and next 10 years.
        private void Payment_Load(object sender, EventArgs e)
        {
            // Variable to track how many years have been added.
            int x = 0;

            // Get current date, then get current year.
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;

            while(x <= 10)
            {
                // Add year to combobox.
                cbExpYear.Items.Add(currentYear);
                // Increment year.
                currentYear++;
                x++;
            }
        }

        // Disables/enables controls based on which payment type is selected.
        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBillCustomer.Checked)
            {
                disableControls();
            }

            else
            {
                enableControls();
            }
        }

        // Disables creditCardType listbox, card number textbox, expiration month combobox,
        // and expiration year combobox.
        private void disableControls()
        {
            lboxCreditCardType.Enabled = false;
            tbCardNumber.Enabled = false;
            cbExpMonth.Enabled = false;
            cbExpYear.Enabled = false;
        }

        // Enables creditCardType listbox, card number textbox, expiration month combobox,
        // and expiration year combobox.
        private void enableControls()
        {
            lboxCreditCardType.Enabled = true;
            tbCardNumber.Enabled = true;
            cbExpMonth.Enabled = true;
            cbExpYear.Enabled = true;
        }
    }
}
