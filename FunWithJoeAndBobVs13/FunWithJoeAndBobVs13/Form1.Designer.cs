namespace FunWithJoeAndBobVs13
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
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.tenToJoeButton = new System.Windows.Forms.Button();
            this.receive5FromBob = new System.Windows.Forms.Button();
            this.joeGives10 = new System.Windows.Forms.Button();
            this.bobGives5toJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Location = new System.Drawing.Point(44, 37);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(68, 20);
            this.joeCashLabel.TabIndex = 0;
            this.joeCashLabel.Text = "labelJoe";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Location = new System.Drawing.Point(44, 76);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(71, 20);
            this.bobCashLabel.TabIndex = 1;
            this.bobCashLabel.Text = "labelBob";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(44, 115);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(79, 20);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "labelBank";
            // 
            // tenToJoeButton
            // 
            this.tenToJoeButton.Location = new System.Drawing.Point(48, 155);
            this.tenToJoeButton.Name = "tenToJoeButton";
            this.tenToJoeButton.Size = new System.Drawing.Size(110, 50);
            this.tenToJoeButton.TabIndex = 3;
            this.tenToJoeButton.Text = "Give $10 to Joe";
            this.tenToJoeButton.UseVisualStyleBackColor = true;
            this.tenToJoeButton.Click += new System.EventHandler(this.tenToJoeButton_Click);
            // 
            // receive5FromBob
            // 
            this.receive5FromBob.Location = new System.Drawing.Point(175, 155);
            this.receive5FromBob.Name = "receive5FromBob";
            this.receive5FromBob.Size = new System.Drawing.Size(110, 50);
            this.receive5FromBob.TabIndex = 4;
            this.receive5FromBob.Text = "Receive $5 from Bob";
            this.receive5FromBob.UseVisualStyleBackColor = true;
            this.receive5FromBob.Click += new System.EventHandler(this.receive5FromBob_Click);
            // 
            // joeGives10
            // 
            this.joeGives10.Location = new System.Drawing.Point(48, 224);
            this.joeGives10.Name = "joeGives10";
            this.joeGives10.Size = new System.Drawing.Size(110, 50);
            this.joeGives10.TabIndex = 5;
            this.joeGives10.Text = "Joe gives $10 to Bob";
            this.joeGives10.UseVisualStyleBackColor = true;
            this.joeGives10.Click += new System.EventHandler(this.joeGives10_Click);
            // 
            // bobGives5toJoe
            // 
            this.bobGives5toJoe.Location = new System.Drawing.Point(175, 224);
            this.bobGives5toJoe.Name = "bobGives5toJoe";
            this.bobGives5toJoe.Size = new System.Drawing.Size(110, 50);
            this.bobGives5toJoe.TabIndex = 6;
            this.bobGives5toJoe.Text = "Bob gives $5 to Joe";
            this.bobGives5toJoe.UseVisualStyleBackColor = true;
            this.bobGives5toJoe.Click += new System.EventHandler(this.bobGives5toJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 345);
            this.Controls.Add(this.bobGives5toJoe);
            this.Controls.Add(this.joeGives10);
            this.Controls.Add(this.receive5FromBob);
            this.Controls.Add(this.tenToJoeButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun With Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button tenToJoeButton;
        private System.Windows.Forms.Button receive5FromBob;
        private System.Windows.Forms.Button joeGives10;
        private System.Windows.Forms.Button bobGives5toJoe;
        
    }

    
}

