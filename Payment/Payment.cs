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

        private void disableControls()
        {
            lboxCreditCardType.Enabled = false;
            tbCardNumber.Enabled = false;
            cbExpMonth.Enabled = false;
            cbExpYear.Enabled = false;
        }

        private void enableControls()
        {
            lboxCreditCardType.Enabled = true;
            tbCardNumber.Enabled = true;
            cbExpMonth.Enabled = true;
            cbExpYear.Enabled = true;
        }
    }
}
