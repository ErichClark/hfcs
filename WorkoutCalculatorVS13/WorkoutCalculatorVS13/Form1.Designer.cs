namespace WorkoutCalculatorVS13
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
            this.minutesWorkedOut_Text = new System.Windows.Forms.Label();
            this.minutes_UpDown = new System.Windows.Forms.NumericUpDown();
            this.CaloriesPerMinute_Text = new System.Windows.Forms.Label();
            this.caloriesPerMinute_UpDown = new System.Windows.Forms.NumericUpDown();
            this.caloriesBurned_Text = new System.Windows.Forms.Label();
            this.caloriesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesPerMinute_UpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // minutesWorkedOut_Text
            // 
            this.minutesWorkedOut_Text.AutoSize = true;
            this.minutesWorkedOut_Text.Location = new System.Drawing.Point(9, 9);
            this.minutesWorkedOut_Text.Name = "minutesWorkedOut_Text";
            this.minutesWorkedOut_Text.Size = new System.Drawing.Size(151, 20);
            this.minutesWorkedOut_Text.TabIndex = 0;
            this.minutesWorkedOut_Text.Text = "Minutes worked out:";
            // 
            // minutes_UpDown
            // 
            this.minutes_UpDown.DecimalPlaces = 1;
            this.minutes_UpDown.Location = new System.Drawing.Point(13, 37);
            this.minutes_UpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.minutes_UpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minutes_UpDown.Name = "minutes_UpDown";
            this.minutes_UpDown.Size = new System.Drawing.Size(84, 26);
            this.minutes_UpDown.TabIndex = 1;
            this.minutes_UpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.minutes_UpDown.ValueChanged += new System.EventHandler(this.minutes_UpDown_ValueChanged);
            // 
            // CaloriesPerMinute_Text
            // 
            this.CaloriesPerMinute_Text.AutoSize = true;
            this.CaloriesPerMinute_Text.Location = new System.Drawing.Point(9, 76);
            this.CaloriesPerMinute_Text.Name = "CaloriesPerMinute_Text";
            this.CaloriesPerMinute_Text.Size = new System.Drawing.Size(149, 20);
            this.CaloriesPerMinute_Text.TabIndex = 2;
            this.CaloriesPerMinute_Text.Text = "Calories per minute:";
            // 
            // caloriesPerMinute_UpDown
            // 
            this.caloriesPerMinute_UpDown.DecimalPlaces = 2;
            this.caloriesPerMinute_UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.caloriesPerMinute_UpDown.Location = new System.Drawing.Point(13, 108);
            this.caloriesPerMinute_UpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.caloriesPerMinute_UpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.caloriesPerMinute_UpDown.Name = "caloriesPerMinute_UpDown";
            this.caloriesPerMinute_UpDown.Size = new System.Drawing.Size(84, 26);
            this.caloriesPerMinute_UpDown.TabIndex = 3;
            this.caloriesPerMinute_UpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.caloriesPerMinute_UpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // caloriesBurned_Text
            // 
            this.caloriesBurned_Text.AutoSize = true;
            this.caloriesBurned_Text.Location = new System.Drawing.Point(9, 151);
            this.caloriesBurned_Text.Name = "caloriesBurned_Text";
            this.caloriesBurned_Text.Size = new System.Drawing.Size(124, 20);
            this.caloriesBurned_Text.TabIndex = 4;
            this.caloriesBurned_Text.Text = "Calories burned:";
            // 
            // caloriesLabel
            // 
            this.caloriesLabel.AutoSize = true;
            this.caloriesLabel.Location = new System.Drawing.Point(13, 184);
            this.caloriesLabel.Name = "caloriesLabel";
            this.caloriesLabel.Size = new System.Drawing.Size(79, 20);
            this.caloriesLabel.TabIndex = 5;
            this.caloriesLabel.Text = "0 Calories";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 236);
            this.Controls.Add(this.caloriesLabel);
            this.Controls.Add(this.caloriesBurned_Text);
            this.Controls.Add(this.caloriesPerMinute_UpDown);
            this.Controls.Add(this.CaloriesPerMinute_Text);
            this.Controls.Add(this.minutes_UpDown);
            this.Controls.Add(this.minutesWorkedOut_Text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Workout Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.minutes_UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caloriesPerMinute_UpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minutesWorkedOut_Text;
        private System.Windows.Forms.NumericUpDown minutes_UpDown;
        private System.Windows.Forms.Label CaloriesPerMinute_Text;
        private System.Windows.Forms.NumericUpDown caloriesPerMinute_UpDown;
        private System.Windows.Forms.Label caloriesBurned_Text;
        private System.Windows.Forms.Label caloriesLabel;
    }
}

