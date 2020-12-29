using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class FormRemainingIncome : Form
    {
        RetrieveData r = new RetrieveData();
        double net = 0;

        public FormRemainingIncome()
        {
            InitializeComponent();
            GetIncomes();
            UpdateAmounts();
            lblGross.ForeColor = Color.LightGray;
            lblNet.ForeColor = Color.LightGray;
        }

        private void CalcAmounts()
        {
            List<double> totalLimitList = r.SelectCCAmounts("cardAmount");
            List<double> totalOwingList = r.SelectCCAmounts("cardOwing");
            List<double> totalExpenseList = r.SelectExpenseAmount();

            double totalLimit = 0;
            double totalOwing = 0;
            double totalExpenses = 0;

            foreach (double d in totalLimitList)
                totalLimit += d;

            foreach (double d in totalOwingList)
                totalOwing += d;

            foreach (double d in totalExpenseList)
                totalExpenses += d;

            net = totalLimit - totalOwing - totalExpenses;
        }

        private void UpdateAmounts()
        {
            
            try
            {
                CalcAmounts();
                double grossInput = Convert.ToDouble(txtbxBank.Text) + Convert.ToDouble(txtbxWallet1.Text) + Convert.ToDouble(txtbxWallet2.Text);
                lblGross.Text = "$" + grossInput;
                lblNet.Text = "$" + (net + grossInput).ToString();
            }
            catch { }
        }

        private void txtbxBank_TextChanged(object sender, EventArgs e)
        {
            changeValue();
        }

        private void txtbxWallet1_TextChanged(object sender, EventArgs e)
        {
            changeValue();
        }

        private void txtbxWallet2_TextChanged(object sender, EventArgs e)
        {
            changeValue();
        }

        private void changeValue()
        {
            lblGross.ForeColor = Color.Red;
            lblNet.ForeColor = Color.Red;
        }

        private void btnUpdateValue_Click(object sender, EventArgs e)
        {
            UpdateAmounts();
            UpdateIncomes();
            lblGross.ForeColor = Color.LightGray;
            lblNet.ForeColor = Color.LightGray;
        }

        private void UpdateIncomes()
        {
            r.UpdateIncome(1, Convert.ToDouble(txtbxBank.Text));
            r.UpdateIncome(2, Convert.ToDouble(txtbxWallet1.Text));
            r.UpdateIncome(3, Convert.ToDouble(txtbxWallet2.Text));
        }

        private void GetIncomes()
        {
            List<double> incomeList = r.SelectIncomes();
            txtbxBank.Text = incomeList[0].ToString();
            txtbxWallet1.Text = incomeList[1].ToString();
            txtbxWallet2.Text = incomeList[2].ToString();
        }
    }
}
