namespace population_Emily
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
            this.lstData = new System.Windows.Forms.ListBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(12, 47);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(180, 95);
            this.lstData.TabIndex = 0;
            // 
            // lblSummary
            // 
            this.lblSummary.Location = new System.Drawing.Point(12, 145);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(180, 87);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Data summary";
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Location = new System.Drawing.Point(20, 31);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(82, 13);
            this.lblDisplayTitle.TabIndex = 2;
            this.lblDisplayTitle.Text = "Year    Increase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayTitle);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lstData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblDisplayTitle;
    }
}

