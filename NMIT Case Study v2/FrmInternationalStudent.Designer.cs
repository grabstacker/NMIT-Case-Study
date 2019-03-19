namespace NMIT_Case_Study_v2
{
    partial class FrmInternationalStudent
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblIelts = new System.Windows.Forms.Label();
            this.lblLoanAmt = new System.Windows.Forms.Label();
            this.txtIELTS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(119, 292);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(182, 26);
            this.txtCountry.TabIndex = 18;
            // 
            // lblIelts
            // 
            this.lblIelts.AutoSize = true;
            this.lblIelts.Location = new System.Drawing.Point(35, 337);
            this.lblIelts.Name = "lblIelts";
            this.lblIelts.Size = new System.Drawing.Size(54, 20);
            this.lblIelts.TabIndex = 17;
            this.lblIelts.Text = "IELTS";
            this.lblIelts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLoanAmt
            // 
            this.lblLoanAmt.AutoSize = true;
            this.lblLoanAmt.Location = new System.Drawing.Point(16, 292);
            this.lblLoanAmt.Name = "lblLoanAmt";
            this.lblLoanAmt.Size = new System.Drawing.Size(64, 20);
            this.lblLoanAmt.TabIndex = 16;
            this.lblLoanAmt.Text = "Country";
            // 
            // txtIELTS
            // 
            this.txtIELTS.Location = new System.Drawing.Point(119, 337);
            this.txtIELTS.Name = "txtIELTS";
            this.txtIELTS.Size = new System.Drawing.Size(182, 26);
            this.txtIELTS.TabIndex = 19;
            // 
            // FrmInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIELTS);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblIelts);
            this.Controls.Add(this.lblLoanAmt);
            this.Name = "FrmInternationalStudent";
            this.Text = "International Student";
            this.Controls.SetChildIndex(this.lblLoanAmt, 0);
            this.Controls.SetChildIndex(this.lblIelts, 0);
            this.Controls.SetChildIndex(this.txtCountry, 0);
            this.Controls.SetChildIndex(this.txtIELTS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblIelts;
        private System.Windows.Forms.Label lblLoanAmt;
        private System.Windows.Forms.TextBox txtIELTS;
    }
}
