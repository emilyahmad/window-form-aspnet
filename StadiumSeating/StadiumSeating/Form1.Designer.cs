namespace StadiumSeating
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
            this.grpTicketsSold = new System.Windows.Forms.GroupBox();
            this.lblDisplayDirections = new System.Windows.Forms.Label();
            this.lblDisplayClassA = new System.Windows.Forms.Label();
            this.lblDisplayClassC = new System.Windows.Forms.Label();
            this.lblDisplayClassB = new System.Windows.Forms.Label();
            this.lblRevenueClassB = new System.Windows.Forms.GroupBox();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.lblDisplayRevenueClassC = new System.Windows.Forms.Label();
            this.lblDisplayRevenueClassB = new System.Windows.Forms.Label();
            this.lblDisplayRevenueClassA = new System.Windows.Forms.Label();
            this.txtClassC = new System.Windows.Forms.TextBox();
            this.txtClassB = new System.Windows.Forms.TextBox();
            this.txtClassA = new System.Windows.Forms.TextBox();
            this.btnCalculateRevenue = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRevenueClassA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRevenueTotal = new System.Windows.Forms.Label();
            this.lblRevenueClassC = new System.Windows.Forms.Label();
            this.grpTicketsSold.SuspendLayout();
            this.lblRevenueClassB.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTicketsSold
            // 
            this.grpTicketsSold.Controls.Add(this.txtClassA);
            this.grpTicketsSold.Controls.Add(this.txtClassB);
            this.grpTicketsSold.Controls.Add(this.txtClassC);
            this.grpTicketsSold.Controls.Add(this.lblDisplayClassC);
            this.grpTicketsSold.Controls.Add(this.lblDisplayClassB);
            this.grpTicketsSold.Controls.Add(this.lblDisplayClassA);
            this.grpTicketsSold.Controls.Add(this.lblDisplayDirections);
            this.grpTicketsSold.Location = new System.Drawing.Point(40, 38);
            this.grpTicketsSold.Name = "grpTicketsSold";
            this.grpTicketsSold.Size = new System.Drawing.Size(242, 369);
            this.grpTicketsSold.TabIndex = 0;
            this.grpTicketsSold.TabStop = false;
            this.grpTicketsSold.Text = "Tickets Sold";
            // 
            // lblDisplayDirections
            // 
            this.lblDisplayDirections.Location = new System.Drawing.Point(6, 41);
            this.lblDisplayDirections.Name = "lblDisplayDirections";
            this.lblDisplayDirections.Size = new System.Drawing.Size(230, 23);
            this.lblDisplayDirections.TabIndex = 2;
            this.lblDisplayDirections.Text = "Enter the number of tickets sold for each class of seats";
            this.lblDisplayDirections.Click += new System.EventHandler(this.lblDisplayDirections_Click);
            // 
            // lblDisplayClassA
            // 
            this.lblDisplayClassA.AutoSize = true;
            this.lblDisplayClassA.Location = new System.Drawing.Point(6, 83);
            this.lblDisplayClassA.Name = "lblDisplayClassA";
            this.lblDisplayClassA.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayClassA.TabIndex = 3;
            this.lblDisplayClassA.Text = "Class A";
            // 
            // lblDisplayClassC
            // 
            this.lblDisplayClassC.AutoSize = true;
            this.lblDisplayClassC.Location = new System.Drawing.Point(6, 168);
            this.lblDisplayClassC.Name = "lblDisplayClassC";
            this.lblDisplayClassC.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayClassC.TabIndex = 5;
            this.lblDisplayClassC.Text = "Class C";
            this.lblDisplayClassC.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDisplayClassB
            // 
            this.lblDisplayClassB.AutoSize = true;
            this.lblDisplayClassB.Location = new System.Drawing.Point(6, 126);
            this.lblDisplayClassB.Name = "lblDisplayClassB";
            this.lblDisplayClassB.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayClassB.TabIndex = 4;
            this.lblDisplayClassB.Text = "Class B";
            this.lblDisplayClassB.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRevenueClassB
            // 
            this.lblRevenueClassB.Controls.Add(this.lblRevenueTotal);
            this.lblRevenueClassB.Controls.Add(this.lblRevenueClassC);
            this.lblRevenueClassB.Controls.Add(this.label1);
            this.lblRevenueClassB.Controls.Add(this.lblRevenueClassA);
            this.lblRevenueClassB.Controls.Add(this.lblDisplayTotal);
            this.lblRevenueClassB.Controls.Add(this.lblDisplayRevenueClassC);
            this.lblRevenueClassB.Controls.Add(this.lblDisplayRevenueClassB);
            this.lblRevenueClassB.Controls.Add(this.lblDisplayRevenueClassA);
            this.lblRevenueClassB.Location = new System.Drawing.Point(459, 38);
            this.lblRevenueClassB.Name = "lblRevenueClassB";
            this.lblRevenueClassB.Size = new System.Drawing.Size(242, 369);
            this.lblRevenueClassB.TabIndex = 6;
            this.lblRevenueClassB.TabStop = false;
            this.lblRevenueClassB.Text = "Revenue Generated";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Location = new System.Drawing.Point(6, 168);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(31, 13);
            this.lblDisplayTotal.TabIndex = 5;
            this.lblDisplayTotal.Text = "Total";
            // 
            // lblDisplayRevenueClassC
            // 
            this.lblDisplayRevenueClassC.AutoSize = true;
            this.lblDisplayRevenueClassC.Location = new System.Drawing.Point(6, 126);
            this.lblDisplayRevenueClassC.Name = "lblDisplayRevenueClassC";
            this.lblDisplayRevenueClassC.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayRevenueClassC.TabIndex = 4;
            this.lblDisplayRevenueClassC.Text = "Class C";
            // 
            // lblDisplayRevenueClassB
            // 
            this.lblDisplayRevenueClassB.AutoSize = true;
            this.lblDisplayRevenueClassB.Location = new System.Drawing.Point(6, 83);
            this.lblDisplayRevenueClassB.Name = "lblDisplayRevenueClassB";
            this.lblDisplayRevenueClassB.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayRevenueClassB.TabIndex = 3;
            this.lblDisplayRevenueClassB.Text = "Class B";
            // 
            // lblDisplayRevenueClassA
            // 
            this.lblDisplayRevenueClassA.AutoSize = true;
            this.lblDisplayRevenueClassA.Location = new System.Drawing.Point(6, 41);
            this.lblDisplayRevenueClassA.Name = "lblDisplayRevenueClassA";
            this.lblDisplayRevenueClassA.Size = new System.Drawing.Size(42, 13);
            this.lblDisplayRevenueClassA.TabIndex = 2;
            this.lblDisplayRevenueClassA.Text = "Class A";
            // 
            // txtClassC
            // 
            this.txtClassC.Location = new System.Drawing.Point(107, 168);
            this.txtClassC.Name = "txtClassC";
            this.txtClassC.Size = new System.Drawing.Size(100, 20);
            this.txtClassC.TabIndex = 6;
            // 
            // txtClassB
            // 
            this.txtClassB.Location = new System.Drawing.Point(107, 126);
            this.txtClassB.Name = "txtClassB";
            this.txtClassB.Size = new System.Drawing.Size(100, 20);
            this.txtClassB.TabIndex = 7;
            // 
            // txtClassA
            // 
            this.txtClassA.Location = new System.Drawing.Point(107, 83);
            this.txtClassA.Name = "txtClassA";
            this.txtClassA.Size = new System.Drawing.Size(100, 20);
            this.txtClassA.TabIndex = 8;
            // 
            // btnCalculateRevenue
            // 
            this.btnCalculateRevenue.Location = new System.Drawing.Point(65, 413);
            this.btnCalculateRevenue.Name = "btnCalculateRevenue";
            this.btnCalculateRevenue.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateRevenue.TabIndex = 7;
            this.btnCalculateRevenue.Text = "Calculate";
            this.btnCalculateRevenue.UseVisualStyleBackColor = true;
            this.btnCalculateRevenue.Click += new System.EventHandler(this.btnCalculateRevenue_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(156, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(552, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblRevenueClassA
            // 
            this.lblRevenueClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenueClassA.Location = new System.Drawing.Point(93, 40);
            this.lblRevenueClassA.Name = "lblRevenueClassA";
            this.lblRevenueClassA.Size = new System.Drawing.Size(109, 23);
            this.lblRevenueClassA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(93, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 7;
            // 
            // lblRevenueTotal
            // 
            this.lblRevenueTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenueTotal.Location = new System.Drawing.Point(93, 158);
            this.lblRevenueTotal.Name = "lblRevenueTotal";
            this.lblRevenueTotal.Size = new System.Drawing.Size(109, 23);
            this.lblRevenueTotal.TabIndex = 9;
            // 
            // lblRevenueClassC
            // 
            this.lblRevenueClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenueClassC.Location = new System.Drawing.Point(93, 125);
            this.lblRevenueClassC.Name = "lblRevenueClassC";
            this.lblRevenueClassC.Size = new System.Drawing.Size(109, 23);
            this.lblRevenueClassC.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateRevenue);
            this.Controls.Add(this.lblRevenueClassB);
            this.Controls.Add(this.grpTicketsSold);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTicketsSold.ResumeLayout(false);
            this.grpTicketsSold.PerformLayout();
            this.lblRevenueClassB.ResumeLayout(false);
            this.lblRevenueClassB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTicketsSold;
        private System.Windows.Forms.Label lblDisplayClassC;
        private System.Windows.Forms.Label lblDisplayClassB;
        private System.Windows.Forms.Label lblDisplayClassA;
        private System.Windows.Forms.Label lblDisplayDirections;
        private System.Windows.Forms.GroupBox lblRevenueClassB;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Label lblDisplayRevenueClassC;
        private System.Windows.Forms.Label lblDisplayRevenueClassB;
        private System.Windows.Forms.Label lblDisplayRevenueClassA;
        private System.Windows.Forms.TextBox txtClassA;
        private System.Windows.Forms.TextBox txtClassB;
        private System.Windows.Forms.TextBox txtClassC;
        private System.Windows.Forms.Button btnCalculateRevenue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRevenueTotal;
        private System.Windows.Forms.Label lblRevenueClassC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRevenueClassA;
    }
}

