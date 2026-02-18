namespace population_form
{
    partial class Form1
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
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.lstData = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Location = new System.Drawing.Point(131, 129);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(73, 13);
            this.lblDisplayTitle.TabIndex = 0;
            this.lblDisplayTitle.Text = "Year Increase";
            // 
            // lstData
            // 
            this.lstData.Location = new System.Drawing.Point(77, 153);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(186, 118);
            this.lstData.TabIndex = 1;
            this.lstData.Text = "Year";
            this.lstData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(77, 296);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(74, 13);
            this.lblSummary.TabIndex = 2;
            this.lblSummary.Text = "Data summary";
            this.lblSummary.Click += new System.EventHandler(this.lblSummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.lblDisplayTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Label lstData;
        private System.Windows.Forms.Label lblSummary;
    }
}

