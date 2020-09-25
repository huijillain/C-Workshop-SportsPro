using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deposit_or_Withdraw_money
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewBalance_Click(object sender, EventArgs e)
        {
            // Local variables
            string options = txtBoxOptions.Text;
            double CurrentBalance = Convert.ToDouble(txtBoxCurrentBalance.Text);
            double Amount = Convert.ToDouble(txtBoxAmount.Text);
            double NewBalance = 0;

            switch (options)
            {
                case "w":
                case "W":
                    NewBalance = CurrentBalance - Amount;
                    break;
                case "d":
                case "D":
                    NewBalance = CurrentBalance + Amount;
                    break;
            }
            NewBalanceLabel.Text = NewBalance.ToString("c");
        }
    }
}
