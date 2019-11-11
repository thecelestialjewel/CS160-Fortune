namespace WindowsFormsApp1
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
            this.lblSelectNumber = new System.Windows.Forms.Label();
            this.numSelector = new System.Windows.Forms.NumericUpDown();
            this.btnClickForFortune = new System.Windows.Forms.Button();
            this.btnLuckyNumbers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectNumber
            // 
            this.lblSelectNumber.AutoSize = true;
            this.lblSelectNumber.Location = new System.Drawing.Point(39, 40);
            this.lblSelectNumber.Name = "lblSelectNumber";
            this.lblSelectNumber.Size = new System.Drawing.Size(111, 13);
            this.lblSelectNumber.TabIndex = 0;
            this.lblSelectNumber.Text = "Select a number 0-21:";
            // 
            // numSelector
            // 
            this.numSelector.Location = new System.Drawing.Point(172, 38);
            this.numSelector.Name = "numSelector";
            this.numSelector.Size = new System.Drawing.Size(136, 20);
            this.numSelector.TabIndex = 2;
            this.numSelector.ValueChanged += new System.EventHandler(this.numSelector_ValueChanged);
            // 
            // btnClickForFortune
            // 
            this.btnClickForFortune.Location = new System.Drawing.Point(42, 103);
            this.btnClickForFortune.Name = "btnClickForFortune";
            this.btnClickForFortune.Size = new System.Drawing.Size(266, 80);
            this.btnClickForFortune.TabIndex = 3;
            this.btnClickForFortune.Text = "Click button for your fortune";
            this.btnClickForFortune.UseVisualStyleBackColor = true;
            this.btnClickForFortune.Click += new System.EventHandler(this.btnClickForFortune_Click);
            // 
            // btnLuckyNumbers
            // 
            this.btnLuckyNumbers.Location = new System.Drawing.Point(98, 232);
            this.btnLuckyNumbers.Name = "btnLuckyNumbers";
            this.btnLuckyNumbers.Size = new System.Drawing.Size(141, 23);
            this.btnLuckyNumbers.TabIndex = 4;
            this.btnLuckyNumbers.Text = "Click for lucky numbers";
            this.btnLuckyNumbers.UseVisualStyleBackColor = true;
            this.btnLuckyNumbers.Click += new System.EventHandler(this.btnLuckyNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 316);
            this.Controls.Add(this.btnLuckyNumbers);
            this.Controls.Add(this.btnClickForFortune);
            this.Controls.Add(this.numSelector);
            this.Controls.Add(this.lblSelectNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectNumber;
        private System.Windows.Forms.NumericUpDown numSelector;
        private System.Windows.Forms.Button btnClickForFortune;
        private System.Windows.Forms.Button btnLuckyNumbers;
    }
}

