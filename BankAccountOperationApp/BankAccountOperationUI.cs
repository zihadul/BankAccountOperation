using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountOperationApp
{
    public partial class BankAccountOperationUI : Form
    {
        public BankAccountOperationUI()
        {
            InitializeComponent();
        }
        AccountCreation customer = new AccountCreation();
        private void createButton_Click(object sender, EventArgs e)
        {
            
            customer.accountNo = accountNoTextBox.Text;
            customer.name = customerNameTextBox.Text;
            MessageBox.Show("Creation Successfull!");
            accountNoTextBox.Clear();
            customerNameTextBox.Clear();
        }
        AccountCreation transection = new AccountCreation();
        private void depositButton_Click(object sender, EventArgs e)
        {

            double newAmount = double.Parse(ammountTextBox.Text);
            transection.Diposit(newAmount);
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double newAmount = double.Parse(ammountTextBox.Text);
            transection.Withdraw(newAmount);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(customer.name+", Your account no: "+customer.accountNo+" and It's balance: "+transection.amount+" tk");
        }
    }
}
