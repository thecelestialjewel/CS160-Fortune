﻿namespace WindowsFormsApp1
{
    partial class Fortune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fortune));
            this.lblSelectNumber = new System.Windows.Forms.Label();
            this.numSelector = new System.Windows.Forms.NumericUpDown();
            this.btnClickForFortune = new System.Windows.Forms.Button();
            this.btnLuckyNumbers = new System.Windows.Forms.Button();
            this.DisclaimerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectNumber
            // 
            this.lblSelectNumber.AutoSize = true;
            this.lblSelectNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelectNumber.ForeColor = System.Drawing.Color.Khaki;
            this.lblSelectNumber.Location = new System.Drawing.Point(317, 50);
            this.lblSelectNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectNumber.Name = "lblSelectNumber";
            this.lblSelectNumber.Size = new System.Drawing.Size(172, 23);
            this.lblSelectNumber.TabIndex = 0;
            this.lblSelectNumber.Text = "Select a number 0-21:";
            // 
            // numSelector
            // 
            this.numSelector.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numSelector.ForeColor = System.Drawing.Color.Khaki;
            this.numSelector.Location = new System.Drawing.Point(355, 90);
            this.numSelector.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numSelector.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSelector.Name = "numSelector";
            this.numSelector.Size = new System.Drawing.Size(93, 30);
            this.numSelector.TabIndex = 2;
            this.numSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSelector.ValueChanged += new System.EventHandler(this.numSelector_ValueChanged);
            // 
            // btnClickForFortune
            // 
            this.btnClickForFortune.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClickForFortune.ForeColor = System.Drawing.Color.Salmon;
            this.btnClickForFortune.Location = new System.Drawing.Point(260, 222);
            this.btnClickForFortune.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClickForFortune.Name = "btnClickForFortune";
            this.btnClickForFortune.Size = new System.Drawing.Size(311, 57);
            this.btnClickForFortune.TabIndex = 3;
            this.btnClickForFortune.Text = "Your fortune awaits..";
            this.btnClickForFortune.UseVisualStyleBackColor = false;
            this.btnClickForFortune.Click += new System.EventHandler(this.btnClickForFortune_Click);
            // 
            // btnLuckyNumbers
            // 
            this.btnLuckyNumbers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuckyNumbers.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLuckyNumbers.Location = new System.Drawing.Point(15, 447);
            this.btnLuckyNumbers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLuckyNumbers.Name = "btnLuckyNumbers";
            this.btnLuckyNumbers.Size = new System.Drawing.Size(259, 41);
            this.btnLuckyNumbers.TabIndex = 4;
            this.btnLuckyNumbers.Text = "Lucky Numbers";
            this.btnLuckyNumbers.UseVisualStyleBackColor = false;
            this.btnLuckyNumbers.Click += new System.EventHandler(this.btnLuckyNumbers_Click);
            // 
            // DisclaimerBtn
            // 
            this.DisclaimerBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DisclaimerBtn.ForeColor = System.Drawing.Color.Red;
            this.DisclaimerBtn.Location = new System.Drawing.Point(601, 447);
            this.DisclaimerBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DisclaimerBtn.Name = "DisclaimerBtn";
            this.DisclaimerBtn.Size = new System.Drawing.Size(213, 41);
            this.DisclaimerBtn.TabIndex = 5;
            this.DisclaimerBtn.Text = "Disclaimer";
            this.DisclaimerBtn.UseVisualStyleBackColor = false;
            this.DisclaimerBtn.Click += new System.EventHandler(this.DisclaimerBtn_Click);
            // 
            // Fortune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 502);
            this.Controls.Add(this.DisclaimerBtn);
            this.Controls.Add(this.btnLuckyNumbers);
            this.Controls.Add(this.btnClickForFortune);
            this.Controls.Add(this.numSelector);
            this.Controls.Add(this.lblSelectNumber);
            this.Font = new System.Drawing.Font("Script MT Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Fortune";
            this.Text = "Fortune";
            this.Load += new System.EventHandler(this.Fortune_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectNumber;
        private System.Windows.Forms.NumericUpDown numSelector;
        private System.Windows.Forms.Button btnClickForFortune;
        private System.Windows.Forms.Button btnLuckyNumbers;
        private System.Windows.Forms.Button DisclaimerBtn;
    }
}

