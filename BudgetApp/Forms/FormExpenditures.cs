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
    public partial class FormExpenditures : Form
    {
        string type = null;

        Expenditure expd = new Expenditure();
        RetrieveData r = new RetrieveData();
        
        public FormExpenditures(string type)
        {
            InitializeComponent();
            this.type = type;

            Clear();
            LoadTable();

            if (type == "Ongoing")
            {
                lblExpenditures.Text = "Ongoing Expenditures";
            } else if (type == "Adhoc")
            {
                lblExpenditures.Text = "Adhoc Expenditures";
            }

        }

        private void getValues()
        {
            expd.expType = type;
            expd.expName = txtbxExpName.Text;
            expd.expAmount = Convert.ToDouble(txtbxExpAmount.Text);
        }

        private void LoadTable()
        {
            DataTable dt = r.SelectExpenditures(type);
            dataExpenseList.DataSource = dt;
            dt.Columns.Remove("expenseType");
        }

        private void Clear()
        {
            txtbxExpID.Text = "";
            txtbxExpName.Text = "Enter Name";
            txtbxExpAmount.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            getValues();

            bool success = r.InsertExpenditure(expd);
            if(success == true)
            {
                //Successfully  Inserted
                MessageBox.Show("New Expense Succesffully Added");
                Clear();
            } else
            {
                MessageBox.Show("Failed to Add New Expense");
            }
            LoadTable();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getValues();
            expd.expID = Convert.ToInt32(txtbxExpID.Text);
            bool success = r.UpdateExpenditure(expd);
            if (success == true)
            {
                //Successfully  Inserted
                MessageBox.Show("Expense Succesffully Updated");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Update Expense");
            }
            LoadTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            expd.expID = Convert.ToInt32(txtbxExpID.Text);
            bool success = r.DeleteExpenditure(expd);
            if (success == true)
            {
                //Successfully  Inserted
                MessageBox.Show("Expense Succesffully Deleted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Delete Expense");
            }
            LoadTable();
        }

        private void dataExpenseList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Identify which row is clicked
            int rowIndex = e.RowIndex;
            txtbxExpID.Text = dataExpenseList.Rows[rowIndex].Cells[0].Value.ToString();
            txtbxExpName.Text = dataExpenseList.Rows[rowIndex].Cells[1].Value.ToString();
            txtbxExpAmount.Text = dataExpenseList.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void txtbxExpName_Click(object sender, EventArgs e)
        {
            txtbxExpName.Text = "";
        }
    }
}
