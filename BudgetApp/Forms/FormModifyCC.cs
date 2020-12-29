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

namespace BudgetApp.Forms
{
    public partial class FormModifyCC : Form
    {
        CreditCards card = new CreditCards();
        RetrieveData r = new RetrieveData();
        string type = "add";

        public FormModifyCC(string type, CreditCards c)
        {
            InitializeComponent();
            this.type = type;

            if(type == "add")
            {
                txtbxCardName.Text = "Enter Name";
                txtbxCardLimit.Text = "0";
                txtbxCardOw.Text = "0";
            }
            else if(type == "edit")
            {
                card = c;
                lblModifyCards.Text = "Update Credit Card";
                btnAdd.Text = "Update";
                txtbxCardName.Text = c.cardName;
                txtbxCardLimit.Text = c.cardAmount.ToString();
                txtbxCardOw.Text = c.cardOwing.ToString();
            }
        }

        private void GetValues()
        {
            double cardLimit = Convert.ToDouble(txtbxCardLimit.Text);
            double cardOwing = Convert.ToDouble(txtbxCardOw.Text);

            card.cardName = txtbxCardName.Text;
            card.cardLimit = cardLimit;
            card.cardAmount = cardLimit - cardOwing;
            card.cardOwing = cardOwing;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetValues();
            bool success = false;
            if(type == "add")
            {
                success = r.InsertCreditCard(card);

            }
            else if (type == "edit")
            {
                success = r.UpdateCreditCard(card);
            }

            if (success == true)
            {
                //Successfully  Inserted
                MessageBox.Show("New Card Succesffully "+type+"ed");
                Close();
            }
            else
            {
                MessageBox.Show("Failed to "+type+" Card");
            }
        }

        private void txtbxCardName_Click(object sender, EventArgs e)
        {
            txtbxCardName.Text = "";
        }

        private void txtbxCardLimit_Click(object sender, EventArgs e)
        {
            txtbxCardLimit.Text = "";
        }
        
        private void txtbxCardOw_Click(object sender, EventArgs e)
        {
            txtbxCardOw.Text = "";
        }
    }
}
