namespace TalkerVs13
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.thingToSayPrompt = new System.Windows.Forms.Label();
            this.numberOfTimesPrompt = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(155, 13);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(221, 26);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.Text = "Hello World!";
            // 
            // thingToSayPrompt
            // 
            this.thingToSayPrompt.AutoSize = true;
            this.thingToSayPrompt.Location = new System.Drawing.Point(25, 18);
            this.thingToSayPrompt.Name = "thingToSayPrompt";
            this.thingToSayPrompt.Size = new System.Drawing.Size(69, 20);
            this.thingToSayPrompt.TabIndex = 1;
            this.thingToSayPrompt.Text = "Say this:";
            // 
            // numberOfTimesPrompt
            // 
            this.numberOfTimesPrompt.AutoSize = true;
            this.numberOfTimesPrompt.Location = new System.Drawing.Point(29, 55);
            this.numberOfTimesPrompt.Name = "numberOfTimesPrompt";
            this.numberOfTimesPrompt.Size = new System.Drawing.Size(82, 20);
            this.numberOfTimesPrompt.TabIndex = 2;
            this.numberOfTimesPrompt.Text = "# of times:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 26);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Speak to me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 147);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numberOfTimesPrompt);
            this.Controls.Add(this.thingToSayPrompt);
            this.Controls.Add(this.TextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label thingToSayPrompt;
        private System.Windows.Forms.Label numberOfTimesPrompt;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;

    }
}

