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
            this.dinnerGuestCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.costText = new System.Windows.Forms.Label();
            this.costDisplay = new System.Windows.Forms.TextBox();
            this.partyChooserTab = new System.Windows.Forms.TabControl();
            this.dinnerPartyTab = new System.Windows.Forms.TabPage();
            this.birthdayPartyTab = new System.Windows.Forms.TabPage();
            this.cakeSizeLabel = new System.Windows.Forms.TextBox();
            this.additionalCharactersLabel = new System.Windows.Forms.TextBox();
            this.additionalCharactersText = new System.Windows.Forms.Label();
            this.birthdayCostBox = new System.Windows.Forms.TextBox();
            this.birthdayCostText = new System.Windows.Forms.Label();
            this.cakeMessageText = new System.Windows.Forms.Label();
            this.cakeMessage = new System.Windows.Forms.TextBox();
            this.cakeSizeText = new System.Windows.Forms.Label();
            this.fancyBirthdayOption = new System.Windows.Forms.CheckBox();
            this.birthdayPartyText = new System.Windows.Forms.Label();
            this.birthdayUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerGuestCountUpDown)).BeginInit();
            this.partyChooserTab.SuspendLayout();
            this.dinnerPartyTab.SuspendLayout();
            this.birthdayPartyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // guestsText
            // 
            this.guestsText.AutoSize = true;
            this.guestsText.Location = new System.Drawing.Point(3, 3);
            this.guestsText.Name = "guestsText";
            this.guestsText.Size = new System.Drawing.Size(187, 20);
            this.guestsText.TabIndex = 0;
            this.guestsText.Text = "Number of dinner guests:";
            // 
            // dinnerGuestCountUpDown
            // 
            this.dinnerGuestCountUpDown.Location = new System.Drawing.Point(7, 26);
            this.dinnerGuestCountUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.dinnerGuestCountUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dinnerGuestCountUpDown.Name = "dinnerGuestCountUpDown";
            this.dinnerGuestCountUpDown.Size = new System.Drawing.Size(120, 26);
            this.dinnerGuestCountUpDown.TabIndex = 1;
            this.dinnerGuestCountUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dinnerGuestCountUpDown.ValueChanged += new System.EventHandler(this.guestCountUpDown_ValueChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(7, 59);
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
            this.healthyBox.Location = new System.Drawing.Point(7, 90);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(140, 24);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // costText
            // 
            this.costText.AutoSize = true;
            this.costText.Location = new System.Drawing.Point(7, 133);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(46, 20);
            this.costText.TabIndex = 4;
            this.costText.Text = "Cost:";
            // 
            // costDisplay
            // 
            this.costDisplay.Location = new System.Drawing.Point(55, 127);
            this.costDisplay.Name = "costDisplay";
            this.costDisplay.Size = new System.Drawing.Size(100, 26);
            this.costDisplay.TabIndex = 5;
            // 
            // partyChooserTab
            // 
            this.partyChooserTab.Controls.Add(this.dinnerPartyTab);
            this.partyChooserTab.Controls.Add(this.birthdayPartyTab);
            this.partyChooserTab.Location = new System.Drawing.Point(0, 0);
            this.partyChooserTab.Name = "partyChooserTab";
            this.partyChooserTab.SelectedIndex = 0;
            this.partyChooserTab.Size = new System.Drawing.Size(346, 281);
            this.partyChooserTab.TabIndex = 6;
            // 
            // dinnerPartyTab
            // 
            this.dinnerPartyTab.Controls.Add(this.guestsText);
            this.dinnerPartyTab.Controls.Add(this.costDisplay);
            this.dinnerPartyTab.Controls.Add(this.dinnerGuestCountUpDown);
            this.dinnerPartyTab.Controls.Add(this.costText);
            this.dinnerPartyTab.Controls.Add(this.fancyBox);
            this.dinnerPartyTab.Controls.Add(this.healthyBox);
            this.dinnerPartyTab.Location = new System.Drawing.Point(4, 29);
            this.dinnerPartyTab.Name = "dinnerPartyTab";
            this.dinnerPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.dinnerPartyTab.Size = new System.Drawing.Size(338, 261);
            this.dinnerPartyTab.TabIndex = 0;
            this.dinnerPartyTab.Text = "Dinner Party";
            this.dinnerPartyTab.UseVisualStyleBackColor = true;
            // 
            // birthdayPartyTab
            // 
            this.birthdayPartyTab.Controls.Add(this.cakeSizeLabel);
            this.birthdayPartyTab.Controls.Add(this.additionalCharactersLabel);
            this.birthdayPartyTab.Controls.Add(this.additionalCharactersText);
            this.birthdayPartyTab.Controls.Add(this.birthdayCostBox);
            this.birthdayPartyTab.Controls.Add(this.birthdayCostText);
            this.birthdayPartyTab.Controls.Add(this.cakeMessageText);
            this.birthdayPartyTab.Controls.Add(this.cakeMessage);
            this.birthdayPartyTab.Controls.Add(this.cakeSizeText);
            this.birthdayPartyTab.Controls.Add(this.fancyBirthdayOption);
            this.birthdayPartyTab.Controls.Add(this.birthdayPartyText);
            this.birthdayPartyTab.Controls.Add(this.birthdayUpDown);
            this.birthdayPartyTab.Location = new System.Drawing.Point(4, 29);
            this.birthdayPartyTab.Name = "birthdayPartyTab";
            this.birthdayPartyTab.Padding = new System.Windows.Forms.Padding(3);
            this.birthdayPartyTab.Size = new System.Drawing.Size(338, 248);
            this.birthdayPartyTab.TabIndex = 1;
            this.birthdayPartyTab.Text = "Birthday Party";
            this.birthdayPartyTab.UseVisualStyleBackColor = true;
            this.birthdayPartyTab.Click += new System.EventHandler(this.birthdayPartyTab_Click);
            // 
            // cakeSizeLabel
            // 
            this.cakeSizeLabel.Location = new System.Drawing.Point(101, 65);
            this.cakeSizeLabel.Name = "cakeSizeLabel";
            this.cakeSizeLabel.Size = new System.Drawing.Size(231, 26);
            this.cakeSizeLabel.TabIndex = 10;
            this.cakeSizeLabel.TextChanged += new System.EventHandler(this.birthdayPartyTab_Click);
            // 
            // additionalCharactersLabel
            // 
            this.additionalCharactersLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.additionalCharactersLabel.Location = new System.Drawing.Point(177, 176);
            this.additionalCharactersLabel.Name = "additionalCharactersLabel";
            this.additionalCharactersLabel.Size = new System.Drawing.Size(28, 26);
            this.additionalCharactersLabel.TabIndex = 9;
            this.additionalCharactersLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // additionalCharactersText
            // 
            this.additionalCharactersText.AutoSize = true;
            this.additionalCharactersText.Location = new System.Drawing.Point(9, 179);
            this.additionalCharactersText.Name = "additionalCharactersText";
            this.additionalCharactersText.Size = new System.Drawing.Size(162, 20);
            this.additionalCharactersText.TabIndex = 8;
            this.additionalCharactersText.Text = "Additional characters:";
            // 
            // birthdayCostBox
            // 
            this.birthdayCostBox.Location = new System.Drawing.Point(62, 211);
            this.birthdayCostBox.Name = "birthdayCostBox";
            this.birthdayCostBox.Size = new System.Drawing.Size(125, 26);
            this.birthdayCostBox.TabIndex = 7;
            // 
            // birthdayCostText
            // 
            this.birthdayCostText.AutoSize = true;
            this.birthdayCostText.Location = new System.Drawing.Point(9, 211);
            this.birthdayCostText.Name = "birthdayCostText";
            this.birthdayCostText.Size = new System.Drawing.Size(46, 20);
            this.birthdayCostText.TabIndex = 6;
            this.birthdayCostText.Text = "Cost:";
            // 
            // cakeMessageText
            // 
            this.cakeMessageText.AutoSize = true;
            this.cakeMessageText.Location = new System.Drawing.Point(9, 94);
            this.cakeMessageText.Name = "cakeMessageText";
            this.cakeMessageText.Size = new System.Drawing.Size(159, 20);
            this.cakeMessageText.TabIndex = 5;
            this.cakeMessageText.Text = "Enter cake message:";
            // 
            // cakeMessage
            // 
            this.cakeMessage.AutoCompleteCustomSource.AddRange(new string[] {
            "0123456789123456",
            "0123456789012345678901234567890123456789"});
            this.cakeMessage.Location = new System.Drawing.Point(13, 117);
            this.cakeMessage.Multiline = true;
            this.cakeMessage.Name = "cakeMessage";
            this.cakeMessage.Size = new System.Drawing.Size(319, 46);
            this.cakeMessage.TabIndex = 4;
            this.cakeMessage.TextChanged += new System.EventHandler(this.cakeMessage_TextChanged);
            // 
            // cakeSizeText
            // 
            this.cakeSizeText.AutoSize = true;
            this.cakeSizeText.Location = new System.Drawing.Point(9, 68);
            this.cakeSizeText.Name = "cakeSizeText";
            this.cakeSizeText.Size = new System.Drawing.Size(86, 20);
            this.cakeSizeText.TabIndex = 3;
            this.cakeSizeText.Text = "Cake size: ";
            // 
            // fancyBirthdayOption
            // 
            this.fancyBirthdayOption.AutoSize = true;
            this.fancyBirthdayOption.Location = new System.Drawing.Point(87, 41);
            this.fancyBirthdayOption.Name = "fancyBirthdayOption";
            this.fancyBirthdayOption.Size = new System.Drawing.Size(129, 24);
            this.fancyBirthdayOption.TabIndex = 2;
            this.fancyBirthdayOption.Text = "Fancy Option";
            this.fancyBirthdayOption.UseVisualStyleBackColor = true;
            this.fancyBirthdayOption.CheckedChanged += new System.EventHandler(this.fancyBirthdayOption_CheckedChanged);
            // 
            // birthdayPartyText
            // 
            this.birthdayPartyText.AutoSize = true;
            this.birthdayPartyText.Location = new System.Drawing.Point(9, 16);
            this.birthdayPartyText.Name = "birthdayPartyText";
            this.birthdayPartyText.Size = new System.Drawing.Size(241, 20);
            this.birthdayPartyText.TabIndex = 1;
            this.birthdayPartyText.Text = "Number of Birthday Party Guests";
            // 
            // birthdayUpDown
            // 
            this.birthdayUpDown.Location = new System.Drawing.Point(13, 39);
            this.birthdayUpDown.Name = "birthdayUpDown";
            this.birthdayUpDown.Size = new System.Drawing.Size(57, 26);
            this.birthdayUpDown.TabIndex = 0;
            this.birthdayUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.birthdayUpDown.ValueChanged += new System.EventHandler(this.birthdayUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 281);
            this.Controls.Add(this.partyChooserTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Better Party Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dinnerGuestCountUpDown)).EndInit();
            this.partyChooserTab.ResumeLayout(false);
            this.dinnerPartyTab.ResumeLayout(false);
            this.dinnerPartyTab.PerformLayout();
            this.birthdayPartyTab.ResumeLayout(false);
            this.birthdayPartyTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guestsText;
        private System.Windows.Forms.NumericUpDown dinnerGuestCountUpDown;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label costText;
        private System.Windows.Forms.TextBox costDisplay;
        private System.Windows.Forms.TabControl partyChooserTab;
        private System.Windows.Forms.TabPage dinnerPartyTab;
        private System.Windows.Forms.TabPage birthdayPartyTab;
        public System.Windows.Forms.TextBox cakeSizeLabel;
        private System.Windows.Forms.TextBox additionalCharactersLabel;
        private System.Windows.Forms.Label additionalCharactersText;
        private System.Windows.Forms.TextBox birthdayCostBox;
        private System.Windows.Forms.Label birthdayCostText;
        private System.Windows.Forms.Label cakeMessageText;
        private System.Windows.Forms.TextBox cakeMessage;
        private System.Windows.Forms.Label cakeSizeText;
        private System.Windows.Forms.CheckBox fancyBirthdayOption;
        private System.Windows.Forms.Label birthdayPartyText;
        private System.Windows.Forms.NumericUpDown birthdayUpDown;
    }
}

