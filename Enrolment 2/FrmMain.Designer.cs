namespace Enrolment_2
{
    partial class FrmMain
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
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnModStudent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(88, 65);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(154, 38);
            this.btnCreateStudent.TabIndex = 0;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click_1);
            // 
            // btnModStudent
            // 
            this.btnModStudent.Location = new System.Drawing.Point(88, 109);
            this.btnModStudent.Name = "btnModStudent";
            this.btnModStudent.Size = new System.Drawing.Size(154, 38);
            this.btnModStudent.TabIndex = 1;
            this.btnModStudent.Text = "Modify Student";
            this.btnModStudent.UseVisualStyleBackColor = true;
            this.btnModStudent.Click += new System.EventHandler(this.btnModStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(404, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.Location = new System.Drawing.Point(54, 242);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(216, 302);
            this.lblStudent.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(543, 776);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnModStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStudent;
    }
}

