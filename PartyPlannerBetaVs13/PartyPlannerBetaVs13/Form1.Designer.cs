namespace PartyPlannerBetaVs13
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
            this.PartyChooserTab = new System.Windows.Forms.TabControl();
            this.DinnerTab = new System.Windows.Forms.TabPage();
            this.BirthdayTab = new System.Windows.Forms.TabPage();
            this.dinnerText = new System.Windows.Forms.Label();
            this.CostText = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DinnerFancyBox = new System.Windows.Forms.CheckBox();
            this.HealthyBox = new System.Windows.Forms.CheckBox();
            this.DinnerCostTextBox = new System.Windows.Forms.TextBox();
            this.BDayGuestsText = new System.Windows.Forms.Label();
            this.BDayGuestsUpDown = new System.Windows.Forms.NumericUpDown();
            this.BDayFancyBox = new System.Windows.Forms.CheckBox();
            this.cakeSizeText = new System.Windows.Forms.Label();
            this.CakeMessageDisplay = new System.Windows.Forms.TextBox();
            this.cakeMessageText = new System.Windows.Forms.Label();
            this.CakeMessageInputBox = new System.Windows.Forms.TextBox();
            this.lettersLeftText = new System.Windows.Forms.Label();
            this.LettersLeftIndicator = new System.Windows.Forms.TextBox();
            this.BDayCostText = new System.Windows.Forms.Label();
            this.BDayCostDisplay = new System.Windows.Forms.TextBox();
            this.PartyChooserTab.SuspendLayout();
            this.DinnerTab.SuspendLayout();
            this.BirthdayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayGuestsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PartyChooserTab
            // 
            this.PartyChooserTab.Controls.Add(this.DinnerTab);
            this.PartyChooserTab.Controls.Add(this.BirthdayTab);
            this.PartyChooserTab.Location = new System.Drawing.Point(-1, -1);
            this.PartyChooserTab.Name = "PartyChooserTab";
            this.PartyChooserTab.SelectedIndex = 0;
            this.PartyChooserTab.Size = new System.Drawing.Size(399, 377);
            this.PartyChooserTab.TabIndex = 0;
            // 
            // DinnerTab
            // 
            this.DinnerTab.Controls.Add(this.DinnerCostTextBox);
            this.DinnerTab.Controls.Add(this.HealthyBox);
            this.DinnerTab.Controls.Add(this.DinnerFancyBox);
            this.DinnerTab.Controls.Add(this.numericUpDown1);
            this.DinnerTab.Controls.Add(this.CostText);
            this.DinnerTab.Controls.Add(this.dinnerText);
            this.DinnerTab.Location = new System.Drawing.Point(4, 29);
            this.DinnerTab.Name = "DinnerTab";
            this.DinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.DinnerTab.Size = new System.Drawing.Size(391, 344);
            this.DinnerTab.TabIndex = 0;
            this.DinnerTab.Text = "Dinner Party";
            this.DinnerTab.UseVisualStyleBackColor = true;
            // 
            // BirthdayTab
            // 
            this.BirthdayTab.Controls.Add(this.BDayCostDisplay);
            this.BirthdayTab.Controls.Add(this.BDayCostText);
            this.BirthdayTab.Controls.Add(this.LettersLeftIndicator);
            this.BirthdayTab.Controls.Add(this.lettersLeftText);
            this.BirthdayTab.Controls.Add(this.CakeMessageInputBox);
            this.BirthdayTab.Controls.Add(this.cakeMessageText);
            this.BirthdayTab.Controls.Add(this.CakeMessageDisplay);
            this.BirthdayTab.Controls.Add(this.cakeSizeText);
            this.BirthdayTab.Controls.Add(this.BDayFancyBox);
            this.BirthdayTab.Controls.Add(this.BDayGuestsUpDown);
            this.BirthdayTab.Controls.Add(this.BDayGuestsText);
            this.BirthdayTab.Location = new System.Drawing.Point(4, 29);
            this.BirthdayTab.Name = "BirthdayTab";
            this.BirthdayTab.Padding = new System.Windows.Forms.Padding(3);
            this.BirthdayTab.Size = new System.Drawing.Size(391, 344);
            this.BirthdayTab.TabIndex = 1;
            this.BirthdayTab.Text = "Birthday Party";
            this.BirthdayTab.UseVisualStyleBackColor = true;
            // 
            // dinnerText
            // 
            this.dinnerText.AutoSize = true;
            this.dinnerText.Location = new System.Drawing.Point(9, 19);
            this.dinnerText.Name = "dinnerText";
            this.dinnerText.Size = new System.Drawing.Size(187, 20);
            this.dinnerText.TabIndex = 0;
            this.dinnerText.Text = "Number of dinner guests:";
            // 
            // CostText
            // 
            this.CostText.AutoSize = true;
            this.CostText.Location = new System.Drawing.Point(9, 160);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(46, 20);
            this.CostText.TabIndex = 1;
            this.CostText.Text = "Cost:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DinnerFancyBox
            // 
            this.DinnerFancyBox.AutoSize = true;
            this.DinnerFancyBox.Location = new System.Drawing.Point(13, 76);
            this.DinnerFancyBox.Name = "DinnerFancyBox";
            this.DinnerFancyBox.Size = new System.Drawing.Size(168, 24);
            this.DinnerFancyBox.TabIndex = 3;
            this.DinnerFancyBox.Text = "Fancy Decorations";
            this.DinnerFancyBox.UseVisualStyleBackColor = true;
            // 
            // HealthyBox
            // 
            this.HealthyBox.AutoSize = true;
            this.HealthyBox.Location = new System.Drawing.Point(13, 107);
            this.HealthyBox.Name = "HealthyBox";
            this.HealthyBox.Size = new System.Drawing.Size(140, 24);
            this.HealthyBox.TabIndex = 4;
            this.HealthyBox.Text = "Healthy Option";
            this.HealthyBox.UseVisualStyleBackColor = true;
            // 
            // DinnerCostTextBox
            // 
            this.DinnerCostTextBox.Location = new System.Drawing.Point(62, 160);
            this.DinnerCostTextBox.Name = "DinnerCostTextBox";
            this.DinnerCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.DinnerCostTextBox.TabIndex = 5;
            // 
            // BDayGuestsText
            // 
            this.BDayGuestsText.AutoSize = true;
            this.BDayGuestsText.Location = new System.Drawing.Point(9, 19);
            this.BDayGuestsText.Name = "BDayGuestsText";
            this.BDayGuestsText.Size = new System.Drawing.Size(205, 20);
            this.BDayGuestsText.TabIndex = 0;
            this.BDayGuestsText.Text = "Number of Birthday Guests:";
            // 
            // BDayGuestsUpDown
            // 
            this.BDayGuestsUpDown.Location = new System.Drawing.Point(13, 43);
            this.BDayGuestsUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BDayGuestsUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BDayGuestsUpDown.Name = "BDayGuestsUpDown";
            this.BDayGuestsUpDown.Size = new System.Drawing.Size(55, 26);
            this.BDayGuestsUpDown.TabIndex = 1;
            this.BDayGuestsUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // BDayFancyBox
            // 
            this.BDayFancyBox.AutoSize = true;
            this.BDayFancyBox.Location = new System.Drawing.Point(89, 44);
            this.BDayFancyBox.Name = "BDayFancyBox";
            this.BDayFancyBox.Size = new System.Drawing.Size(129, 24);
            this.BDayFancyBox.TabIndex = 2;
            this.BDayFancyBox.Text = "Fancy Option";
            this.BDayFancyBox.UseVisualStyleBackColor = true;
            // 
            // cakeSizeText
            // 
            this.cakeSizeText.AutoSize = true;
            this.cakeSizeText.Location = new System.Drawing.Point(13, 88);
            this.cakeSizeText.Name = "cakeSizeText";
            this.cakeSizeText.Size = new System.Drawing.Size(82, 20);
            this.cakeSizeText.TabIndex = 3;
            this.cakeSizeText.Text = "Cake size:";
            // 
            // CakeMessageDisplay
            // 
            this.CakeMessageDisplay.Location = new System.Drawing.Point(102, 81);
            this.CakeMessageDisplay.Name = "CakeMessageDisplay";
            this.CakeMessageDisplay.Size = new System.Drawing.Size(264, 26);
            this.CakeMessageDisplay.TabIndex = 4;
            // 
            // cakeMessageText
            // 
            this.cakeMessageText.AutoSize = true;
            this.cakeMessageText.Location = new System.Drawing.Point(13, 120);
            this.cakeMessageText.Name = "cakeMessageText";
            this.cakeMessageText.Size = new System.Drawing.Size(159, 20);
            this.cakeMessageText.TabIndex = 5;
            this.cakeMessageText.Text = "Enter cake message:";
            // 
            // CakeMessageInputBox
            // 
            this.CakeMessageInputBox.Location = new System.Drawing.Point(13, 156);
            this.CakeMessageInputBox.Multiline = true;
            this.CakeMessageInputBox.Name = "CakeMessageInputBox";
            this.CakeMessageInputBox.Size = new System.Drawing.Size(353, 61);
            this.CakeMessageInputBox.TabIndex = 6;
            // 
            // lettersLeftText
            // 
            this.lettersLeftText.AutoSize = true;
            this.lettersLeftText.Location = new System.Drawing.Point(13, 233);
            this.lettersLeftText.Name = "lettersLeftText";
            this.lettersLeftText.Size = new System.Drawing.Size(165, 20);
            this.lettersLeftText.TabIndex = 7;
            this.lettersLeftText.Text = "Additional Characters:";
            // 
            // LettersLeftIndicator
            // 
            this.LettersLeftIndicator.BackColor = System.Drawing.Color.LightGreen;
            this.LettersLeftIndicator.Location = new System.Drawing.Point(185, 226);
            this.LettersLeftIndicator.Name = "LettersLeftIndicator";
            this.LettersLeftIndicator.Size = new System.Drawing.Size(33, 26);
            this.LettersLeftIndicator.TabIndex = 8;
            // 
            // BDayCostText
            // 
            this.BDayCostText.AutoSize = true;
            this.BDayCostText.Location = new System.Drawing.Point(13, 267);
            this.BDayCostText.Name = "BDayCostText";
            this.BDayCostText.Size = new System.Drawing.Size(108, 20);
            this.BDayCostText.TabIndex = 9;
            this.BDayCostText.Text = "Birthday Cost:";
            // 
            // BDayCostDisplay
            // 
            this.BDayCostDisplay.Location = new System.Drawing.Point(128, 260);
            this.BDayCostDisplay.Name = "BDayCostDisplay";
            this.BDayCostDisplay.Size = new System.Drawing.Size(100, 26);
            this.BDayCostDisplay.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.PartyChooserTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            this.PartyChooserTab.ResumeLayout(false);
            this.DinnerTab.ResumeLayout(false);
            this.DinnerTab.PerformLayout();
            this.BirthdayTab.ResumeLayout(false);
            this.BirthdayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDayGuestsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PartyChooserTab;
        private System.Windows.Forms.TabPage DinnerTab;
        private System.Windows.Forms.TabPage BirthdayTab;
        private System.Windows.Forms.TextBox DinnerCostTextBox;
        private System.Windows.Forms.CheckBox HealthyBox;
        private System.Windows.Forms.CheckBox DinnerFancyBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label CostText;
        private System.Windows.Forms.Label dinnerText;
        private System.Windows.Forms.TextBox BDayCostDisplay;
        private System.Windows.Forms.Label BDayCostText;
        private System.Windows.Forms.TextBox LettersLeftIndicator;
        private System.Windows.Forms.Label lettersLeftText;
        private System.Windows.Forms.TextBox CakeMessageInputBox;
        private System.Windows.Forms.Label cakeMessageText;
        private System.Windows.Forms.TextBox CakeMessageDisplay;
        private System.Windows.Forms.Label cakeSizeText;
        private System.Windows.Forms.CheckBox BDayFancyBox;
        private System.Windows.Forms.NumericUpDown BDayGuestsUpDown;
        private System.Windows.Forms.Label BDayGuestsText;
    }
}

