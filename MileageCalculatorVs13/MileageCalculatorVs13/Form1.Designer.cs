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
            this.amountOwedLabel.Location = new System.Drawing.Point(162, 100);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(85, 29);
            this.amountOwedLabel.TabIndex = 2;
            this.amountOwedLabel.Text = "label1";
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
            1,
            0,
            0,
            0});
            // 
            // owedText
            // 
            this.owedText.AutoSize = true;
            this.owedText.Location = new System.Drawing.Point(31, 100);
            this.owedText.Name = "owedText";
            this.owedText.Size = new System.Drawing.Size(107, 20);
            this.owedText.TabIndex = 5;
            this.owedText.Text = "Amount owed";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(167, 132);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 45);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 205);
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
    }
}

