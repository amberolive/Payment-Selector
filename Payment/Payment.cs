/* Written by Amber Rivera
 * C# Lab 5
 * Payment Application
 * 
 * This form allows user to enter payment information and display
 * it on the customer form. Performs data validation before display.
 */

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
        Customer customerForm;
        String customerName;
        int currentMonth;
        int currentYear;

        public Payment(Customer customerForm)
        {
            InitializeComponent();
            this.customerForm = customerForm;
            this.customerName = customerForm.getCustomerName();
        }

        // Populates expiration year combobox with the current and next 10 years.
        private void Payment_Load(object sender, EventArgs e)
        {
            // Variable to track how many years have been added.
            int x = 0;

            // Get current date, then get current year.
            DateTime currentDate = DateTime.Now;
            int year = currentDate.Year;
            this.currentYear = currentDate.Year;
            this.currentMonth = currentDate.Month;

            while(x <= 10)
            {
                // Add year to combobox.
                cbExpYear.Items.Add(year);
                // Increment year.
                year++;
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

        // Returns true if card type has been selected.
        private bool isCardTypeSelected()
        {
            if(lboxCreditCardType.SelectedIndex >= 0)
            {
                return true;
            }

            return false;
        }

        // Returns true if card number is all digits and is not null or empty.
        private bool isCardNumberGiven()
        {
            // Make sure card number is between 16 and 19 characters long.
            if(tbCardNumber.Text.Length >= 16 && tbCardNumber.Text.Length <= 19)
            {
                // Make sure card number is made of digits.
                foreach(char number in tbCardNumber.Text)
                {
                    if(!Char.IsDigit(number))
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        // Returns true if an expiration month has been selected.
        private bool isExpMonthSelected()
        {
            if(cbExpMonth.SelectedIndex != -1)
            {
                return true;
            }

            return false;
        }

        // Returns true if an expiration year has been selected.
        private bool isExpYearSelected()
        {
            if(cbExpYear.SelectedIndex != -1)
            {
                return true;
            }

            return false;
        }

        // Returns true if credit card expiration date is in the future.
        private bool isExpDateValid()
        {
            int yearSelected = 0;

            if(int.TryParse(cbExpYear.SelectedItem.ToString(), out yearSelected))
            {
                if ((cbExpMonth.SelectedIndex + 1) > currentMonth || yearSelected > currentYear)
                {
                    return true;
                }
            }
            
            return false;
        }

        // If card type and expiration date selected and valid card number selected,
        // display payment method information on customer form.
        private void btOk_Click(object sender, EventArgs e)
        {
            String paymentMethod = "";
            
            // Executed if user selected Credit Card.
            if(rbCreditCard.Checked)
            {
                if(isCardTypeSelected())
                {
                    if(isCardNumberGiven())
                    {
                        if(isExpMonthSelected())
                        {
                            if(isExpYearSelected())
                            {
                                if(isExpDateValid())
                                {
                                    paymentMethod += customerName + "'s Payment Information\n\n";
                                    paymentMethod += "Charge to Credit Card:\n\n";
                                    paymentMethod += "Card Type: " + lboxCreditCardType.SelectedItem.ToString() + "\n";
                                    paymentMethod += "Card Number: " + tbCardNumber.Text + "\n";
                                    paymentMethod += "Expiration Date: " + cbExpMonth.SelectedItem.ToString() +
                                                     " " + cbExpYear.SelectedItem.ToString() + "\n";
                                    paymentMethod += "Default Billing: " + cbSetDefaultBillMethod.Checked.ToString();

                                    customerForm.setDisplayPamentMethod(paymentMethod);
                                    this.Close();
                                }

                                else
                                {
                                    MessageBox.Show("Credit card has expired.");
                                }
                            }

                            // Expiration year not selected error.
                            else
                            {
                                MessageBox.Show("Please select an expiration year.");
                                cbExpYear.Focus();
                            }
                        }

                        // Expiration month not selected error.
                        else
                        {
                            MessageBox.Show("Please select an expiration month.");
                            cbExpMonth.Focus();
                        }
                    }   

                    // Invalid credit card number error.
                    else
                    {
                        MessageBox.Show("Invalid credit card number.");
                        tbCardNumber.Focus();
                    }
                }

                // Credit card type not selected error.
                else
                {
                    MessageBox.Show("Please select a credit card type.");
                    lboxCreditCardType.Focus();
                }
            }

            else if(rbBillCustomer.Checked)
            {
                paymentMethod += customerName + "'s Payment Information\n\n";
                paymentMethod += "Bill Customer\n\n";
                paymentMethod += "Default Billing: " + cbSetDefaultBillMethod.Checked.ToString();

                customerForm.setDisplayPamentMethod(paymentMethod);
                this.Close();
            }
        }

        // Closes form if user confirms that they want to.
        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to leave payment form?", "Leave Form?",
                     MessageBoxButtons.YesNo);

            // Close form if user wants to.
            if(answer == DialogResult.Yes)
            {
                this.Close();
            }  
        }
    }
}
