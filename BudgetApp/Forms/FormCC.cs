using BudgetApp.Classes;
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
    public partial class FormCC : Form
    {

        RetrieveData r = new RetrieveData();
        CreditCards c = new CreditCards();
        form1 form;

        public FormCC(form1 form)
        {
            InitializeComponent();
            this.form = form;
            LoadTable();
        }

        private void CalcGross()
        {
            List<double> totalLimitList = r.SelectCCAmounts("cardAmount");
            List<double> totalOwingList = r.SelectCCAmounts("cardOwing");

            double totalLimit = 0;
            double totalOwing = 0;

            foreach (double d in totalLimitList)
            {
                totalLimit += d;
            }
            foreach (double d in totalOwingList)
            {
                totalOwing += d;
            }

            lblTotalLimit.Text = totalLimit.ToString();
            lblTotalAvailable.Text = (totalLimit - totalOwing).ToString();
            lblTotalOwing.Text = totalOwing.ToString();
        }

        private void LoadTable()
        {
            DataTable dt = r.SelectCreditCards();
            dataCCList.DataSource = dt;
            CalcGross();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form.OpenACC("add", c);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            r.DeleteCreditCard(c);
            LoadTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            form.OpenACC("edit", c);
        }

        private void dataCCList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            c.cardID = Convert.ToInt32(dataCCList.Rows[rowIndex].Cells[0].Value);
            c.cardName = dataCCList.Rows[rowIndex].Cells[1].Value.ToString();
            c.cardLimit = Convert.ToDouble(dataCCList.Rows[rowIndex].Cells[2].Value);
            c.cardAmount = Convert.ToDouble(dataCCList.Rows[rowIndex].Cells[3].Value);
            c.cardOwing = Convert.ToDouble(dataCCList.Rows[rowIndex].Cells[4].Value);
        }
    }
}
