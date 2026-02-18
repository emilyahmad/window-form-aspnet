namespace FoodCharge
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
            this.lblDisplayFoodCharge = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayFoodCharge
            // 
            this.lblDisplayFoodCharge.AutoSize = true;
            this.lblDisplayFoodCharge.Location = new System.Drawing.Point(78, 71);
            this.lblDisplayFoodCharge.Name = "lblDisplayFoodCharge";
            this.lblDisplayFoodCharge.Size = new System.Drawing.Size(31, 13);
            this.lblDisplayFoodCharge.TabIndex = 0;
            this.lblDisplayFoodCharge.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(81, 108);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(81, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(81, 197);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(84, 13);
            this.lblBill.TabIndex = 3;
            this.lblBill.Text = "Bill displays here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDisplayFoodCharge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayFoodCharge;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBill;
    }
}

