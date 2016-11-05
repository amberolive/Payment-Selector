/* Written by Amber Rivera
 * C# Lab 5
 * Payment Application
 * 
 * This form allows user to select a customer, open payment form, save payment methods,
 * and clear payment methods.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class Customer : Form
    {
        // Declare dictionary used to store customer Payment Methods.
        public Dictionary<String, String> customerPaymentMethod = new Dictionary<string, string>();

        public Customer()
        {
            InitializeComponent();
        }

        // Populates customer name combobox with names from Names.txt.
        // Adds names as keys to the customerPaymentMethod dictionary.
        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                // Variable to hold name from file.
                String name;

                StreamReader namesFile;

                // Opening file.
                namesFile = File.OpenText("Names.txt");
                // Add names to combobox and dictionary.
                while (!namesFile.EndOfStream)
                {
                    name = namesFile.ReadLine();

                    customerPaymentMethod.Add(name, "");
                  
                    cbCustNames.Items.Add(name);
                }
                // Close file.
                namesFile.Close();
            }

            // Catch a FileNotFoundException.
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file \"Names.txt\"");
            } 
            // Catch any other exceptions thrown.
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Close form.
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open payment form if user has selected a customer.
        private void btSelectPayment_Click(object sender, EventArgs e)
        {
            if(cbCustNames.SelectedIndex != -1)
            {
                Payment paymentForm = new Payment(this);
                paymentForm.Show();
            }

            else
            {
                MessageBox.Show("Please select a customer's name.");
            }
            
        }

        // Set displayPaymentMethod text.
        public void setDisplayPamentMethod(String paymentMethod)
        {
            displayPaymentMethod.Text = paymentMethod;
        } 

        // Get selected customer name.
        public String getCustomerName()
        {
            String customerName = cbCustNames.SelectedItem.ToString();
            return customerName;
        }

        // Change payment method based on name.
        public void changeCustomerPaymentMethod(String name, String paymentMethod)
        {
            customerPaymentMethod[name] = paymentMethod;
        }

        // Display customer payment method, if it has been saved, when user selects name.
        private void cbCustNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayPaymentMethod.Text = customerPaymentMethod[cbCustNames.SelectedItem.ToString()];
        }

        // Changes customer payment method if user has selected a name and payment method.
        private void btSave_Click(object sender, EventArgs e)
        {

            if(cbCustNames.SelectedIndex != -1)
            {
                if(displayPaymentMethod.Text != "")
                {
                    changeCustomerPaymentMethod(getCustomerName(), displayPaymentMethod.Text);
                    MessageBox.Show("Payment method for " + getCustomerName() + " saved successfully.");
                }

                else
                {
                    MessageBox.Show("Please select a payment method.");
                }
            }

            else
            {
                MessageBox.Show("Please select a customer.");
            }
                
        }

        // Clear payment methods from dictionary.
        private void clearSavedPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Do you want to clear all saved payment methods?", "Clear",
                    MessageBoxButtons.YesNo);

            // Clear payment methods if user wants to.
            if (answer == DialogResult.Yes)
            {
                foreach (String name in customerPaymentMethod.Keys.ToList())
                {
                    customerPaymentMethod[name] = "";
                    displayPaymentMethod.Text = "";
                }
            }
            
        }

        // Open payment about box.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentAboutBox about = new PaymentAboutBox();
            about.Show();
        }
    }
}
