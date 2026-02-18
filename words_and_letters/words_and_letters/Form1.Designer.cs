namespace words_and_letters
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCountWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter text";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(45, 54);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(690, 168);
            this.txtString.TabIndex = 1;
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Location = new System.Drawing.Point(45, 238);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(690, 51);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "label2";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnCountWords
            // 
            this.btnCountWords.Location = new System.Drawing.Point(343, 292);
            this.btnCountWords.Name = "btnCountWords";
            this.btnCountWords.Size = new System.Drawing.Size(85, 26);
            this.btnCountWords.TabIndex = 3;
            this.btnCountWords.Text = "Count Words";
            this.btnCountWords.UseVisualStyleBackColor = true;
            this.btnCountWords.Click += new System.EventHandler(this.btnCountWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCountWords);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnCountWords;
    }
}

