namespace Deposit_or_Withdraw_money
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnNewBalance = new System.Windows.Forms.Button();
            this.NewBalanceLabel = new System.Windows.Forms.Label();
            this.radioBtnDeposit = new System.Windows.Forms.RadioButton();
            this.txtBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.txtBoxOptions = new System.Windows.Forms.TextBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.txtBoxCurrentBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(48, 31);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(94, 15);
            this.lblCurrentBalance.TabIndex = 0;
            this.lblCurrentBalance.Text = "&Current Balance:";
            // 
            // btnNewBalance
            // 
            this.btnNewBalance.Location = new System.Drawing.Point(46, 216);
            this.btnNewBalance.Name = "btnNewBalance";
            this.btnNewBalance.Size = new System.Drawing.Size(96, 22);
            this.btnNewBalance.TabIndex = 6;
            this.btnNewBalance.Text = "&New Balance";
            this.btnNewBalance.UseVisualStyleBackColor = true;
            this.btnNewBalance.Click += new System.EventHandler(this.btnNewBalance_Click);
            // 
            // NewBalanceLabel
            // 
            this.NewBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewBalanceLabel.Location = new System.Drawing.Point(163, 211);
            this.NewBalanceLabel.Name = "NewBalanceLabel";
            this.NewBalanceLabel.Size = new System.Drawing.Size(122, 27);
            this.NewBalanceLabel.TabIndex = 7;
            // 
            // radioBtnDeposit
            // 
            this.radioBtnDeposit.AutoSize = true;
            this.radioBtnDeposit.Location = new System.Drawing.Point(38, 95);
            this.radioBtnDeposit.Name = "radioBtnDeposit";
            this.radioBtnDeposit.Size = new System.Drawing.Size(65, 19);
            this.radioBtnDeposit.TabIndex = 2;
            this.radioBtnDeposit.TabStop = true;
            this.radioBtnDeposit.Text = "&Deposit";
            this.radioBtnDeposit.UseVisualStyleBackColor = true;
            // 
            // txtBoxDepositAmount
            // 
            this.txtBoxDepositAmount.Location = new System.Drawing.Point(146, 88);
            this.txtBoxDepositAmount.Name = "txtBoxDepositAmount";
            this.txtBoxDepositAmount.Size = new System.Drawing.Size(120, 23);
            this.txtBoxDepositAmount.TabIndex = 4;
            // 
            // txtBoxOptions
            // 
            this.txtBoxOptions.Location = new System.Drawing.Point(242, 80);
            this.txtBoxOptions.Name = "txtBoxOptions";
            this.txtBoxOptions.Size = new System.Drawing.Size(48, 23);
            this.txtBoxOptions.TabIndex = 5;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(43, 88);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(193, 15);
            this.lblOptions.TabIndex = 8;
            this.lblOptions.Text = "\"w\" for withdraw or \"d\" for deposit:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(88, 144);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(54, 15);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount:";
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(163, 136);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(124, 23);
            this.txtBoxAmount.TabIndex = 10;
            // 
            // txtBoxCurrentBalance
            // 
            this.txtBoxCurrentBalance.Location = new System.Drawing.Point(163, 23);
            this.txtBoxCurrentBalance.Name = "txtBoxCurrentBalance";
            this.txtBoxCurrentBalance.Size = new System.Drawing.Size(127, 23);
            this.txtBoxCurrentBalance.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(333, 277);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.NewBalanceLabel);
            this.Controls.Add(this.btnNewBalance);
            this.Controls.Add(this.txtBoxOptions);
            this.Controls.Add(this.txtBoxCurrentBalance);
            this.Controls.Add(this.lblCurrentBalance);
            this.Name = "Form1";
            this.Text = "Bank Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Button btnNewBalance;
        private System.Windows.Forms.Label NewBalanceLabel;
        private System.Windows.Forms.RadioButton radioBtnDeposit;
        private System.Windows.Forms.TextBox txtBoxDepositAmount;
        private System.Windows.Forms.TextBox txtBoxOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.TextBox txtBoxCurrentBalance;
    }
}

