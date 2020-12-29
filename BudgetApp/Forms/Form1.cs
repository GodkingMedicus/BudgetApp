using BudgetApp.Classes;
using BudgetApp.Forms;
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
    public partial class form1 : Form
    {

        public form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        public double GetNetIncome()
        {
            double netIncome = 0;



            return netIncome;
        }
        #region Design
        private void customizeDesign()
        {
            panelCCSub.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCCSub.Visible == true)
                panelCCSub.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        #region Buttons
        private void buttonSFM_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSPF());
            hideSubMenu();
        }

        private void buttonRI_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRemainingIncome());
            hideSubMenu();
        }

        private void buttonCC_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCCSub);
        }
        #region CreditCardSubMenu
        private void buttonVC_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCC(this));
            hideSubMenu();
        }

        private void buttonACC_Click(object sender, EventArgs e)
        {
            openChildForm(new FormModifyCC("add", null));
            hideSubMenu();
        }
        #endregion

        private void buttonOME_Click(object sender, EventArgs e)
        {
            openChildForm(new FormExpenditures("Ongoing"));
        }

        private void buttonAHE_Click(object sender, EventArgs e)
        {
            openChildForm(new FormExpenditures("Adhoc"));
        }
        #endregion

        public void OpenCC()
        {
            openChildForm(new FormCC(this));
        }
        public void OpenACC(string type, CreditCards c)
        {
            if(type == "add")
                openChildForm(new FormModifyCC("add", null));
            else if(type == "edit")
                openChildForm(new FormModifyCC("edit", c));

        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

    }
}
