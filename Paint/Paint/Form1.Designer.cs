namespace Paint
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
            this.lblDisplaySquareFeetWallSpace = new System.Windows.Forms.Label();
            this.lblDisplayPriceOfPaint = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSquareFeet = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplaySquareFeetWallSpace
            // 
            this.lblDisplaySquareFeetWallSpace.AutoSize = true;
            this.lblDisplaySquareFeetWallSpace.Location = new System.Drawing.Point(65, 84);
            this.lblDisplaySquareFeetWallSpace.Name = "lblDisplaySquareFeetWallSpace";
            this.lblDisplaySquareFeetWallSpace.Size = new System.Drawing.Size(62, 13);
            this.lblDisplaySquareFeetWallSpace.TabIndex = 0;
            this.lblDisplaySquareFeetWallSpace.Text = "Square feet";
            // 
            // lblDisplayPriceOfPaint
            // 
            this.lblDisplayPriceOfPaint.AutoSize = true;
            this.lblDisplayPriceOfPaint.Location = new System.Drawing.Point(65, 135);
            this.lblDisplayPriceOfPaint.Name = "lblDisplayPriceOfPaint";
            this.lblDisplayPriceOfPaint.Size = new System.Drawing.Size(31, 13);
            this.lblDisplayPriceOfPaint.TabIndex = 1;
            this.lblDisplayPriceOfPaint.Text = "Price";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(284, 72);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(298, 140);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 132);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtSquareFeet
            // 
            this.txtSquareFeet.Location = new System.Drawing.Point(139, 81);
            this.txtSquareFeet.Name = "txtSquareFeet";
            this.txtSquareFeet.Size = new System.Drawing.Size(100, 20);
            this.txtSquareFeet.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(121, 189);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSquareFeet);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDisplayPriceOfPaint);
            this.Controls.Add(this.lblDisplaySquareFeetWallSpace);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplaySquareFeetWallSpace;
        private System.Windows.Forms.Label lblDisplayPriceOfPaint;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSquareFeet;
        private System.Windows.Forms.Button btnCalculate;
    }
}

