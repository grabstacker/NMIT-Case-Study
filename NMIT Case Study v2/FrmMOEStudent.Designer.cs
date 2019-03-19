namespace NMIT_Case_Study_v2
{
    partial class FrmMOEStudent
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
            this.lblLoanAmt = new System.Windows.Forms.Label();
            this.lblFullTime = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLoanAmt
            // 
            this.lblLoanAmt.AutoSize = true;
            this.lblLoanAmt.Location = new System.Drawing.Point(25, 292);
            this.lblLoanAmt.Name = "lblLoanAmt";
            this.lblLoanAmt.Size = new System.Drawing.Size(91, 20);
            this.lblLoanAmt.TabIndex = 12;
            this.lblLoanAmt.Text = "Loan Amt $";
            // 
            // lblFullTime
            // 
            this.lblFullTime.AutoSize = true;
            this.lblFullTime.Location = new System.Drawing.Point(44, 337);
            this.lblFullTime.Name = "lblFullTime";
            this.lblFullTime.Size = new System.Drawing.Size(72, 20);
            this.lblFullTime.TabIndex = 13;
            this.lblFullTime.Text = "Full Time";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(128, 292);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(182, 26);
            this.txtLoan.TabIndex = 14;
            // 
            // chkFullTime
            // 
            this.chkFullTime.AutoSize = true;
            this.chkFullTime.Location = new System.Drawing.Point(128, 337);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(22, 21);
            this.chkFullTime.TabIndex = 15;
            this.chkFullTime.UseVisualStyleBackColor = true;
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkFullTime);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.lblFullTime);
            this.Controls.Add(this.lblLoanAmt);
            this.Name = "FrmMOEStudent";
            this.Text = "MOE Student";
            this.Controls.SetChildIndex(this.lblLoanAmt, 0);
            this.Controls.SetChildIndex(this.lblFullTime, 0);
            this.Controls.SetChildIndex(this.txtLoan, 0);
            this.Controls.SetChildIndex(this.chkFullTime, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoanAmt;
        private System.Windows.Forms.Label lblFullTime;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.CheckBox chkFullTime;
    }
}
