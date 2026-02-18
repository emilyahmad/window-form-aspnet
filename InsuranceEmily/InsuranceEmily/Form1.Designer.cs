namespace InsuranceEmily
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
            this.lblDisplayReplacement = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMinInsurance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayReplacement
            // 
            this.lblDisplayReplacement.AutoSize = true;
            this.lblDisplayReplacement.Location = new System.Drawing.Point(51, 57);
            this.lblDisplayReplacement.Name = "lblDisplayReplacement";
            this.lblDisplayReplacement.Size = new System.Drawing.Size(106, 13);
            this.lblDisplayReplacement.TabIndex = 0;
            this.lblDisplayReplacement.Text = "Replacement Cost: $";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(163, 54);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(291, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMinInsurance
            // 
            this.lblMinInsurance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinInsurance.Location = new System.Drawing.Point(51, 91);
            this.lblMinInsurance.Name = "lblMinInsurance";
            this.lblMinInsurance.Size = new System.Drawing.Size(328, 38);
            this.lblMinInsurance.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMinInsurance);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblDisplayReplacement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayReplacement;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMinInsurance;
    }
}

