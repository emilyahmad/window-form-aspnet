namespace TestProgram2
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
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplayItem = new System.Windows.Forms.Label();
            this.lblDisplayPrice = new System.Windows.Forms.Label();
            this.lblMarkupPrice = new System.Windows.Forms.Label();
            this.lblDisplayMarkupPrice = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(253, 189);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(120, 23);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Calculate new price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(420, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplayItem
            // 
            this.lblDisplayItem.AutoSize = true;
            this.lblDisplayItem.Location = new System.Drawing.Point(245, 105);
            this.lblDisplayItem.Name = "lblDisplayItem";
            this.lblDisplayItem.Size = new System.Drawing.Size(86, 13);
            this.lblDisplayItem.TabIndex = 0;
            this.lblDisplayItem.Text = "Item to purchase";
            // 
            // lblDisplayPrice
            // 
            this.lblDisplayPrice.AutoSize = true;
            this.lblDisplayPrice.Location = new System.Drawing.Point(417, 105);
            this.lblDisplayPrice.Name = "lblDisplayPrice";
            this.lblDisplayPrice.Size = new System.Drawing.Size(110, 13);
            this.lblDisplayPrice.TabIndex = 3;
            this.lblDisplayPrice.Text = "Please enter the price";
            // 
            // lblMarkupPrice
            // 
            this.lblMarkupPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMarkupPrice.Location = new System.Drawing.Point(250, 267);
            this.lblMarkupPrice.Name = "lblMarkupPrice";
            this.lblMarkupPrice.Size = new System.Drawing.Size(245, 23);
            this.lblMarkupPrice.TabIndex = 6;
            // 
            // lblDisplayMarkupPrice
            // 
            this.lblDisplayMarkupPrice.AutoSize = true;
            this.lblDisplayMarkupPrice.Location = new System.Drawing.Point(250, 243);
            this.lblDisplayMarkupPrice.Name = "lblDisplayMarkupPrice";
            this.lblDisplayMarkupPrice.Size = new System.Drawing.Size(105, 13);
            this.lblDisplayMarkupPrice.TabIndex = 5;
            this.lblDisplayMarkupPrice.Text = "Display markup price";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(248, 121);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(420, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblDisplayMarkupPrice);
            this.Controls.Add(this.lblMarkupPrice);
            this.Controls.Add(this.lblDisplayPrice);
            this.Controls.Add(this.lblDisplayItem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplayItem;
        private System.Windows.Forms.Label lblDisplayPrice;
        private System.Windows.Forms.Label lblMarkupPrice;
        private System.Windows.Forms.Label lblDisplayMarkupPrice;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

