namespace ImprovedPartyPlannerVs13
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
            this.guestsText = new System.Windows.Forms.Label();
            this.guestCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.costText = new System.Windows.Forms.Label();
            this.costDisplay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guestCountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // guestsText
            // 
            this.guestsText.AutoSize = true;
            this.guestsText.Location = new System.Drawing.Point(13, 13);
            this.guestsText.Name = "guestsText";
            this.guestsText.Size = new System.Drawing.Size(135, 20);
            this.guestsText.TabIndex = 0;
            this.guestsText.Text = "Number of guests";
            // 
            // guestCountUpDown
            // 
            this.guestCountUpDown.Location = new System.Drawing.Point(17, 36);
            this.guestCountUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.guestCountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.guestCountUpDown.Name = "guestCountUpDown";
            this.guestCountUpDown.Size = new System.Drawing.Size(120, 26);
            this.guestCountUpDown.TabIndex = 1;
            this.guestCountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.guestCountUpDown.ValueChanged += new System.EventHandler(this.guestCountUpDown_ValueChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(17, 69);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(168, 24);
            this.fancyBox.TabIndex = 2;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(17, 100);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(113, 24);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "healthyBox";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // costText
            // 
            this.costText.AutoSize = true;
            this.costText.Location = new System.Drawing.Point(17, 143);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(42, 20);
            this.costText.TabIndex = 4;
            this.costText.Text = "Cost";
            // 
            // costDisplay
            // 
            this.costDisplay.Location = new System.Drawing.Point(65, 137);
            this.costDisplay.Name = "costDisplay";
            this.costDisplay.Size = new System.Drawing.Size(100, 26);
            this.costDisplay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 181);
            this.Controls.Add(this.costDisplay);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.healthyBox);
            this.Controls.Add(this.fancyBox);
            this.Controls.Add(this.guestCountUpDown);
            this.Controls.Add(this.guestsText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Better Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.guestCountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guestsText;
        private System.Windows.Forms.NumericUpDown guestCountUpDown;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label costText;
        private System.Windows.Forms.TextBox costDisplay;
    }
}

