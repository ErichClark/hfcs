namespace ElephantsVs13
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
            this.lloydButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.lucindaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloydButton
            // 
            this.lloydButton.Location = new System.Drawing.Point(59, 12);
            this.lloydButton.Name = "lloydButton";
            this.lloydButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lloydButton.Size = new System.Drawing.Size(150, 40);
            this.lloydButton.TabIndex = 0;
            this.lloydButton.Text = "Lloyd";
            this.lloydButton.UseVisualStyleBackColor = true;
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(59, 104);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(150, 40);
            this.swapButton.TabIndex = 1;
            this.swapButton.Text = "Swap!";
            this.swapButton.UseVisualStyleBackColor = true;
            // 
            // lucindaButton
            // 
            this.lucindaButton.Location = new System.Drawing.Point(59, 58);
            this.lucindaButton.Name = "lucindaButton";
            this.lucindaButton.Size = new System.Drawing.Size(150, 40);
            this.lucindaButton.TabIndex = 2;
            this.lucindaButton.Text = "Lucinda";
            this.lucindaButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 158);
            this.Controls.Add(this.lucindaButton);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.lloydButton);
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloydButton;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button lucindaButton;
    }
}

