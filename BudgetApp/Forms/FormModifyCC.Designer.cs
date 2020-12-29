namespace BudgetApp.Forms
{
    partial class FormModifyCC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModifyCards = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbxCardName = new System.Windows.Forms.TextBox();
            this.txtbxCardLimit = new System.Windows.Forms.TextBox();
            this.txtbxCardOw = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifyCards
            // 
            this.lblModifyCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModifyCards.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifyCards.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblModifyCards.Location = new System.Drawing.Point(20, 61);
            this.lblModifyCards.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblModifyCards.Name = "lblModifyCards";
            this.lblModifyCards.Size = new System.Drawing.Size(488, 50);
            this.lblModifyCards.TabIndex = 7;
            this.lblModifyCards.Text = "Add Credit Card";
            this.lblModifyCards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Location = new System.Drawing.Point(301, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 39);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtbxCardOw);
            this.panel1.Controls.Add(this.txtbxCardLimit);
            this.panel1.Controls.Add(this.txtbxCardName);
            this.panel1.Location = new System.Drawing.Point(20, 239);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 352);
            this.panel1.TabIndex = 8;
            // 
            // txtbxCardName
            // 
            this.txtbxCardName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtbxCardName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxCardName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCardName.ForeColor = System.Drawing.Color.White;
            this.txtbxCardName.Location = new System.Drawing.Point(336, 41);
            this.txtbxCardName.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCardName.Name = "txtbxCardName";
            this.txtbxCardName.Size = new System.Drawing.Size(117, 25);
            this.txtbxCardName.TabIndex = 29;
            this.txtbxCardName.Text = "Test";
            this.txtbxCardName.Click += new System.EventHandler(this.txtbxCardName_Click);
            // 
            // txtbxCardLimit
            // 
            this.txtbxCardLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtbxCardLimit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxCardLimit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCardLimit.ForeColor = System.Drawing.Color.White;
            this.txtbxCardLimit.Location = new System.Drawing.Point(336, 95);
            this.txtbxCardLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCardLimit.Name = "txtbxCardLimit";
            this.txtbxCardLimit.Size = new System.Drawing.Size(117, 25);
            this.txtbxCardLimit.TabIndex = 30;
            this.txtbxCardLimit.Text = "Test";
            this.txtbxCardLimit.Click += new System.EventHandler(this.txtbxCardLimit_Click);
            // 
            // txtbxCardOw
            // 
            this.txtbxCardOw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtbxCardOw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxCardOw.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCardOw.ForeColor = System.Drawing.Color.White;
            this.txtbxCardOw.Location = new System.Drawing.Point(336, 148);
            this.txtbxCardOw.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxCardOw.Name = "txtbxCardOw";
            this.txtbxCardOw.Size = new System.Drawing.Size(117, 25);
            this.txtbxCardOw.TabIndex = 32;
            this.txtbxCardOw.Text = "Test";
            this.txtbxCardOw.Click += new System.EventHandler(this.txtbxCardOw_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(42, 181);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 1);
            this.panel5.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(45, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Owing";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(44, 78);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(411, 1);
            this.panel8.TabIndex = 42;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(44, 128);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(411, 1);
            this.panel9.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(46, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Limit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(46, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Card Name";
            // 
            // FormModifyCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(535, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblModifyCards);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormModifyCC";
            this.Text = "FormModifyCC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblModifyCards;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxCardOw;
        private System.Windows.Forms.TextBox txtbxCardLimit;
        private System.Windows.Forms.TextBox txtbxCardName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}