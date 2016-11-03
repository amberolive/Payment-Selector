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
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                String name;

                StreamReader namesFile;

                namesFile = File.OpenText("Names.txt");

                while (!namesFile.EndOfStream)
                {
                    name = namesFile.ReadLine();

                    cbCustNames.Items.Add(name);
                }

                namesFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        public void setDisplayPamentMethod(String paymentMethod)
        {
            displayPaymentMethod.Text = paymentMethod;
        } 

        public String getCustomerName()
        {
            String customerName = cbCustNames.SelectedItem.ToString();
            return customerName;
        }
    }
}
