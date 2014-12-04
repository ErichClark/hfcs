namespace MileageCalculatorVs13
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
            this.startText = new System.Windows.Forms.Label();
            this.endText = new System.Windows.Forms.Label();
            this.amountOwedLabel = new System.Windows.Forms.Label();
            this.startMiles = new System.Windows.Forms.NumericUpDown();
            this.endMiles = new System.Windows.Forms.NumericUpDown();
            this.owedText = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.rateLabel = new System.Windows.Forms.Label();
            this.milesTraveledLabel = new System.Windows.Forms.Label();
            this.rateText = new System.Windows.Forms.Label();
            this.milesTraveledText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startMiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMiles)).BeginInit();
            this.SuspendLayout();
            // 
            // startText
            // 
            this.startText.AutoSize = true;
            this.startText.Location = new System.Drawing.Point(27, 28);
            this.startText.Name = "startText";
            this.startText.Size = new System.Drawing.Size(124, 20);
            this.startText.TabIndex = 0;
            this.startText.Text = "Starting Mileage";
            // 
            // endText
            // 
            this.endText.AutoSize = true;
            this.endText.Location = new System.Drawing.Point(31, 64);
            this.endText.Name = "endText";
            this.endText.Size = new System.Drawing.Size(118, 20);
            this.endText.TabIndex = 1;
            this.endText.Text = "Ending mileage";
            // 
            // amountOwedLabel
            // 
            this.amountOwedLabel.AutoSize = true;
            this.amountOwedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwedLabel.Location = new System.Drawing.Point(162, 262);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(48, 29);
            this.amountOwedLabel.TabIndex = 2;
            this.amountOwedLabel.Text = "$ 0";
            // 
            // startMiles
            // 
            this.startMiles.Location = new System.Drawing.Point(167, 21);
            this.startMiles.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startMiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMiles.Name = "startMiles";
            this.startMiles.Size = new System.Drawing.Size(120, 26);
            this.startMiles.TabIndex = 3;
            this.startMiles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endMiles
            // 
            this.endMiles.Location = new System.Drawing.Point(167, 64);
            this.endMiles.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endMiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMiles.Name = "endMiles";
            this.endMiles.Size = new System.Drawing.Size(120, 26);
            this.endMiles.TabIndex = 4;
            this.endMiles.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // owedText
            // 
            this.owedText.AutoSize = true;
            this.owedText.Location = new System.Drawing.Point(27, 271);
            this.owedText.Name = "owedText";
            this.owedText.Size = new System.Drawing.Size(107, 20);
            this.owedText.TabIndex = 5;
            this.owedText.Text = "Amount owed";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(167, 109);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(162, 217);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(77, 29);
            this.rateLabel.TabIndex = 7;
            this.rateLabel.Text = "$ 0.00";
            // 
            // milesTraveledLabel
            // 
            this.milesTraveledLabel.AutoSize = true;
            this.milesTraveledLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesTraveledLabel.Location = new System.Drawing.Point(162, 176);
            this.milesTraveledLabel.Name = "milesTraveledLabel";
            this.milesTraveledLabel.Size = new System.Drawing.Size(44, 29);
            this.milesTraveledLabel.TabIndex = 8;
            this.milesTraveledLabel.Text = "   0";
            // 
            // rateText
            // 
            this.rateText.AutoSize = true;
            this.rateText.Location = new System.Drawing.Point(27, 226);
            this.rateText.Name = "rateText";
            this.rateText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rateText.Size = new System.Drawing.Size(103, 20);
            this.rateText.TabIndex = 9;
            this.rateText.Text = "Rate per Mile";
            // 
            // milesTraveledText
            // 
            this.milesTraveledText.AutoSize = true;
            this.milesTraveledText.Location = new System.Drawing.Point(27, 183);
            this.milesTraveledText.Name = "milesTraveledText";
            this.milesTraveledText.Size = new System.Drawing.Size(109, 20);
            this.milesTraveledText.TabIndex = 10;
            this.milesTraveledText.Text = "Miles Traveled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 300);
            this.Controls.Add(this.milesTraveledText);
            this.Controls.Add(this.rateText);
            this.Controls.Add(this.milesTraveledLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.owedText);
            this.Controls.Add(this.endMiles);
            this.Controls.Add(this.startMiles);
            this.Controls.Add(this.amountOwedLabel);
            this.Controls.Add(this.endText);
            this.Controls.Add(this.startText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startMiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startText;
        private System.Windows.Forms.Label endText;
        private System.Windows.Forms.Label amountOwedLabel;
        private System.Windows.Forms.NumericUpDown startMiles;
        private System.Windows.Forms.NumericUpDown endMiles;
        private System.Windows.Forms.Label owedText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label milesTraveledLabel;
        private System.Windows.Forms.Label rateText;
        private System.Windows.Forms.Label milesTraveledText;
    }
}

