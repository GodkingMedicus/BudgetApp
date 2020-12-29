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
    public partial class FormSPF : Form
    {

        RetrieveData r = new RetrieveData();
        double remainingAmount = 0;

        public FormSPF()
        {
            InitializeComponent();
            UpdateRemainingAmount();
            calculateDays();
        }

        private void UpdateRemainingAmount()
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

            remainingAmount = totalLimit - totalOwing - totalExpenses;
        }

        private void calculateDays()
        {
            DateTime payday = new DateTime();
            try
            {
                payday = DateTime.Parse(txtbxDate.Text);
            }
            catch { }

            double remainingDays = (payday - DateTime.Now).Days;
            double remainingWeeks = Math.Ceiling(remainingDays / 7);

            lblRDays.Text = remainingDays.ToString();
            lblRWeeks.Text = remainingWeeks.ToString();

            lblRPDay.Text = "$" + Math.Round(remainingAmount / remainingDays, 2);
            lblRPWeek.Text = "$" + Math.Round(remainingAmount / remainingWeeks, 2);
            lblRPMonth.Text = "$" + remainingAmount;

        }

        private void txtbxDate_TextChanged(object sender, EventArgs e)
        {
            calculateDays();
        }
    }
}
