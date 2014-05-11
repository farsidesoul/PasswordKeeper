namespace PasswordKeeper
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
            this.allowLowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.allowedLabel = new System.Windows.Forms.Label();
            this.requiredLabel = new System.Windows.Forms.Label();
            this.allowUppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.allowNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.allowSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.allowUnderscoreCheckBox = new System.Windows.Forms.CheckBox();
            this.allowSpaceCheckBox = new System.Windows.Forms.CheckBox();
            this.allowOthersCheckBox = new System.Windows.Forms.CheckBox();
            this.requireOthersCheckBox = new System.Windows.Forms.CheckBox();
            this.requireSpaceCheckBox = new System.Windows.Forms.CheckBox();
            this.requireUnderscoreCheckBox = new System.Windows.Forms.CheckBox();
            this.requireSpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.requireNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.requireUppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.requireLowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.minLengthLabel = new System.Windows.Forms.Label();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.charactersLabel = new System.Windows.Forms.Label();
            this.lowercaseLabel = new System.Windows.Forms.Label();
            this.uppercaseLabel = new System.Windows.Forms.Label();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.specialLabel = new System.Windows.Forms.Label();
            this.underscoreLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.otherCharsLabel = new System.Windows.Forms.Label();
            this.otherCharsTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.minLengthTextBox = new System.Windows.Forms.TextBox();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.seperatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allowLowercaseCheckBox
            // 
            this.allowLowercaseCheckBox.AutoSize = true;
            this.allowLowercaseCheckBox.Location = new System.Drawing.Point(155, 25);
            this.allowLowercaseCheckBox.Name = "allowLowercaseCheckBox";
            this.allowLowercaseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowLowercaseCheckBox.TabIndex = 0;
            this.allowLowercaseCheckBox.UseVisualStyleBackColor = true;
            this.allowLowercaseCheckBox.CheckedChanged += new System.EventHandler(this.allowLowerCaseCheckBox_CheckedChanged);
            // 
            // allowedLabel
            // 
            this.allowedLabel.AutoSize = true;
            this.allowedLabel.Location = new System.Drawing.Point(141, 9);
            this.allowedLabel.Name = "allowedLabel";
            this.allowedLabel.Size = new System.Drawing.Size(44, 13);
            this.allowedLabel.TabIndex = 1;
            this.allowedLabel.Text = "Allowed";
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.Location = new System.Drawing.Point(206, 9);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(50, 13);
            this.requiredLabel.TabIndex = 2;
            this.requiredLabel.Text = "Required";
            // 
            // allowUppercaseCheckBox
            // 
            this.allowUppercaseCheckBox.AutoSize = true;
            this.allowUppercaseCheckBox.Location = new System.Drawing.Point(155, 45);
            this.allowUppercaseCheckBox.Name = "allowUppercaseCheckBox";
            this.allowUppercaseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowUppercaseCheckBox.TabIndex = 3;
            this.allowUppercaseCheckBox.UseVisualStyleBackColor = true;
            this.allowUppercaseCheckBox.CheckedChanged += new System.EventHandler(this.allowUppercaseCheckBox_CheckedChanged);
            // 
            // allowNumbersCheckBox
            // 
            this.allowNumbersCheckBox.AutoSize = true;
            this.allowNumbersCheckBox.Location = new System.Drawing.Point(155, 65);
            this.allowNumbersCheckBox.Name = "allowNumbersCheckBox";
            this.allowNumbersCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowNumbersCheckBox.TabIndex = 4;
            this.allowNumbersCheckBox.UseVisualStyleBackColor = true;
            this.allowNumbersCheckBox.CheckedChanged += new System.EventHandler(this.allowNumbersCheckBox_CheckedChanged);
            // 
            // allowSpecialCharsCheckBox
            // 
            this.allowSpecialCharsCheckBox.AutoSize = true;
            this.allowSpecialCharsCheckBox.Location = new System.Drawing.Point(155, 85);
            this.allowSpecialCharsCheckBox.Name = "allowSpecialCharsCheckBox";
            this.allowSpecialCharsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowSpecialCharsCheckBox.TabIndex = 5;
            this.allowSpecialCharsCheckBox.UseVisualStyleBackColor = true;
            this.allowSpecialCharsCheckBox.CheckedChanged += new System.EventHandler(this.allowSpecialCharsCheckBox_CheckedChanged);
            // 
            // allowUnderscoreCheckBox
            // 
            this.allowUnderscoreCheckBox.AutoSize = true;
            this.allowUnderscoreCheckBox.Location = new System.Drawing.Point(155, 105);
            this.allowUnderscoreCheckBox.Name = "allowUnderscoreCheckBox";
            this.allowUnderscoreCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowUnderscoreCheckBox.TabIndex = 6;
            this.allowUnderscoreCheckBox.UseVisualStyleBackColor = true;
            this.allowUnderscoreCheckBox.CheckedChanged += new System.EventHandler(this.allowUnderscoreCheckBox_CheckedChanged);
            // 
            // allowSpaceCheckBox
            // 
            this.allowSpaceCheckBox.AutoSize = true;
            this.allowSpaceCheckBox.Location = new System.Drawing.Point(155, 125);
            this.allowSpaceCheckBox.Name = "allowSpaceCheckBox";
            this.allowSpaceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowSpaceCheckBox.TabIndex = 7;
            this.allowSpaceCheckBox.UseVisualStyleBackColor = true;
            this.allowSpaceCheckBox.CheckedChanged += new System.EventHandler(this.allowSpaceCheckBox_CheckedChanged);
            // 
            // allowOthersCheckBox
            // 
            this.allowOthersCheckBox.AutoSize = true;
            this.allowOthersCheckBox.Location = new System.Drawing.Point(155, 145);
            this.allowOthersCheckBox.Name = "allowOthersCheckBox";
            this.allowOthersCheckBox.Size = new System.Drawing.Size(15, 14);
            this.allowOthersCheckBox.TabIndex = 8;
            this.allowOthersCheckBox.UseVisualStyleBackColor = true;
            this.allowOthersCheckBox.CheckedChanged += new System.EventHandler(this.allowOthersCheckBox_CheckedChanged);
            // 
            // requireOthersCheckBox
            // 
            this.requireOthersCheckBox.AutoSize = true;
            this.requireOthersCheckBox.Location = new System.Drawing.Point(223, 145);
            this.requireOthersCheckBox.Name = "requireOthersCheckBox";
            this.requireOthersCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireOthersCheckBox.TabIndex = 15;
            this.requireOthersCheckBox.UseVisualStyleBackColor = true;
            this.requireOthersCheckBox.CheckedChanged += new System.EventHandler(this.requireOthersCheckBox_CheckedChanged);
            // 
            // requireSpaceCheckBox
            // 
            this.requireSpaceCheckBox.AutoSize = true;
            this.requireSpaceCheckBox.Location = new System.Drawing.Point(223, 125);
            this.requireSpaceCheckBox.Name = "requireSpaceCheckBox";
            this.requireSpaceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireSpaceCheckBox.TabIndex = 14;
            this.requireSpaceCheckBox.UseVisualStyleBackColor = true;
            this.requireSpaceCheckBox.CheckedChanged += new System.EventHandler(this.requireSpaceCheckBox_CheckedChanged);
            // 
            // requireUnderscoreCheckBox
            // 
            this.requireUnderscoreCheckBox.AutoSize = true;
            this.requireUnderscoreCheckBox.Location = new System.Drawing.Point(223, 105);
            this.requireUnderscoreCheckBox.Name = "requireUnderscoreCheckBox";
            this.requireUnderscoreCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireUnderscoreCheckBox.TabIndex = 13;
            this.requireUnderscoreCheckBox.UseVisualStyleBackColor = true;
            this.requireUnderscoreCheckBox.CheckedChanged += new System.EventHandler(this.requireUnderscoreCheckBox_CheckedChanged);
            // 
            // requireSpecialCharsCheckBox
            // 
            this.requireSpecialCharsCheckBox.AutoSize = true;
            this.requireSpecialCharsCheckBox.Location = new System.Drawing.Point(223, 85);
            this.requireSpecialCharsCheckBox.Name = "requireSpecialCharsCheckBox";
            this.requireSpecialCharsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireSpecialCharsCheckBox.TabIndex = 12;
            this.requireSpecialCharsCheckBox.UseVisualStyleBackColor = true;
            this.requireSpecialCharsCheckBox.CheckedChanged += new System.EventHandler(this.requireSpecialCharsCheckBox_CheckedChanged);
            // 
            // requireNumbersCheckBox
            // 
            this.requireNumbersCheckBox.AutoSize = true;
            this.requireNumbersCheckBox.Location = new System.Drawing.Point(223, 65);
            this.requireNumbersCheckBox.Name = "requireNumbersCheckBox";
            this.requireNumbersCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireNumbersCheckBox.TabIndex = 11;
            this.requireNumbersCheckBox.UseVisualStyleBackColor = true;
            this.requireNumbersCheckBox.CheckedChanged += new System.EventHandler(this.requireNumbersCheckBox_CheckedChanged);
            // 
            // requireUppercaseCheckBox
            // 
            this.requireUppercaseCheckBox.AutoSize = true;
            this.requireUppercaseCheckBox.Location = new System.Drawing.Point(223, 45);
            this.requireUppercaseCheckBox.Name = "requireUppercaseCheckBox";
            this.requireUppercaseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireUppercaseCheckBox.TabIndex = 10;
            this.requireUppercaseCheckBox.UseVisualStyleBackColor = true;
            this.requireUppercaseCheckBox.CheckedChanged += new System.EventHandler(this.requireUppercaseCheckBox_CheckedChanged);
            // 
            // requireLowercaseCheckBox
            // 
            this.requireLowercaseCheckBox.AutoSize = true;
            this.requireLowercaseCheckBox.Location = new System.Drawing.Point(223, 25);
            this.requireLowercaseCheckBox.Name = "requireLowercaseCheckBox";
            this.requireLowercaseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireLowercaseCheckBox.TabIndex = 9;
            this.requireLowercaseCheckBox.UseVisualStyleBackColor = true;
            this.requireLowercaseCheckBox.CheckedChanged += new System.EventHandler(this.requireLowercaseCheckBox_CheckedChanged);
            // 
            // minLengthLabel
            // 
            this.minLengthLabel.AutoSize = true;
            this.minLengthLabel.Location = new System.Drawing.Point(281, 26);
            this.minLengthLabel.Name = "minLengthLabel";
            this.minLengthLabel.Size = new System.Drawing.Size(66, 13);
            this.minLengthLabel.TabIndex = 16;
            this.minLengthLabel.Text = "Min. Length:";
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Location = new System.Drawing.Point(281, 45);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(69, 13);
            this.maxLengthLabel.TabIndex = 17;
            this.maxLengthLabel.Text = "Max. Length:";
            // 
            // charactersLabel
            // 
            this.charactersLabel.AutoSize = true;
            this.charactersLabel.Location = new System.Drawing.Point(12, 9);
            this.charactersLabel.Name = "charactersLabel";
            this.charactersLabel.Size = new System.Drawing.Size(61, 13);
            this.charactersLabel.TabIndex = 18;
            this.charactersLabel.Text = "Characters:";
            // 
            // lowercaseLabel
            // 
            this.lowercaseLabel.AutoSize = true;
            this.lowercaseLabel.Location = new System.Drawing.Point(12, 26);
            this.lowercaseLabel.Name = "lowercaseLabel";
            this.lowercaseLabel.Size = new System.Drawing.Size(86, 13);
            this.lowercaseLabel.TabIndex = 19;
            this.lowercaseLabel.Text = "Lowercase (abc)";
            // 
            // uppercaseLabel
            // 
            this.uppercaseLabel.AutoSize = true;
            this.uppercaseLabel.Location = new System.Drawing.Point(12, 46);
            this.uppercaseLabel.Name = "uppercaseLabel";
            this.uppercaseLabel.Size = new System.Drawing.Size(89, 13);
            this.uppercaseLabel.TabIndex = 20;
            this.uppercaseLabel.Text = "Uppercase (ABC)";
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Location = new System.Drawing.Point(12, 66);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(76, 13);
            this.numbersLabel.TabIndex = 21;
            this.numbersLabel.Text = "Numbers (123)";
            // 
            // specialLabel
            // 
            this.specialLabel.AutoSize = true;
            this.specialLabel.Location = new System.Drawing.Point(12, 86);
            this.specialLabel.Name = "specialLabel";
            this.specialLabel.Size = new System.Drawing.Size(88, 13);
            this.specialLabel.TabIndex = 22;
            this.specialLabel.Text = "Special ($%!@...)";
            // 
            // underscoreLabel
            // 
            this.underscoreLabel.AutoSize = true;
            this.underscoreLabel.Location = new System.Drawing.Point(12, 106);
            this.underscoreLabel.Name = "underscoreLabel";
            this.underscoreLabel.Size = new System.Drawing.Size(77, 13);
            this.underscoreLabel.TabIndex = 23;
            this.underscoreLabel.Text = "Underscore (_)";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Location = new System.Drawing.Point(12, 126);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(50, 13);
            this.spaceLabel.TabIndex = 24;
            this.spaceLabel.Text = "Space ( )";
            // 
            // otherCharsLabel
            // 
            this.otherCharsLabel.AutoSize = true;
            this.otherCharsLabel.Location = new System.Drawing.Point(12, 146);
            this.otherCharsLabel.Name = "otherCharsLabel";
            this.otherCharsLabel.Size = new System.Drawing.Size(36, 13);
            this.otherCharsLabel.TabIndex = 25;
            this.otherCharsLabel.Text = "Other:";
            // 
            // otherCharsTextBox
            // 
            this.otherCharsTextBox.Location = new System.Drawing.Point(49, 142);
            this.otherCharsTextBox.Name = "otherCharsTextBox";
            this.otherCharsTextBox.Size = new System.Drawing.Size(100, 20);
            this.otherCharsTextBox.TabIndex = 26;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 27;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(70, 189);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(186, 20);
            this.passwordTextBox.TabIndex = 28;
            // 
            // minLengthTextBox
            // 
            this.minLengthTextBox.Location = new System.Drawing.Point(353, 22);
            this.minLengthTextBox.Name = "minLengthTextBox";
            this.minLengthTextBox.Size = new System.Drawing.Size(36, 20);
            this.minLengthTextBox.TabIndex = 29;
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.Location = new System.Drawing.Point(353, 43);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.Size = new System.Drawing.Size(36, 20);
            this.maxLengthTextBox.TabIndex = 30;
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.Location = new System.Drawing.Point(284, 187);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(75, 23);
            this.generatePasswordButton.TabIndex = 31;
            this.generatePasswordButton.Text = "Generate";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(232, 225);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 32;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(313, 225);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // seperatorLabel
            // 
            this.seperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperatorLabel.Location = new System.Drawing.Point(0, 220);
            this.seperatorLabel.Name = "seperatorLabel";
            this.seperatorLabel.Size = new System.Drawing.Size(402, 2);
            this.seperatorLabel.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 254);
            this.Controls.Add(this.seperatorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.maxLengthTextBox);
            this.Controls.Add(this.minLengthTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.otherCharsTextBox);
            this.Controls.Add(this.otherCharsLabel);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.underscoreLabel);
            this.Controls.Add(this.specialLabel);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.uppercaseLabel);
            this.Controls.Add(this.lowercaseLabel);
            this.Controls.Add(this.charactersLabel);
            this.Controls.Add(this.maxLengthLabel);
            this.Controls.Add(this.minLengthLabel);
            this.Controls.Add(this.requireOthersCheckBox);
            this.Controls.Add(this.requireSpaceCheckBox);
            this.Controls.Add(this.requireUnderscoreCheckBox);
            this.Controls.Add(this.requireSpecialCharsCheckBox);
            this.Controls.Add(this.requireNumbersCheckBox);
            this.Controls.Add(this.requireUppercaseCheckBox);
            this.Controls.Add(this.requireLowercaseCheckBox);
            this.Controls.Add(this.allowOthersCheckBox);
            this.Controls.Add(this.allowSpaceCheckBox);
            this.Controls.Add(this.allowUnderscoreCheckBox);
            this.Controls.Add(this.allowSpecialCharsCheckBox);
            this.Controls.Add(this.allowNumbersCheckBox);
            this.Controls.Add(this.allowUppercaseCheckBox);
            this.Controls.Add(this.requiredLabel);
            this.Controls.Add(this.allowedLabel);
            this.Controls.Add(this.allowLowercaseCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox allowLowercaseCheckBox;
        private System.Windows.Forms.Label allowedLabel;
        private System.Windows.Forms.Label requiredLabel;
        private System.Windows.Forms.CheckBox allowUppercaseCheckBox;
        private System.Windows.Forms.CheckBox allowNumbersCheckBox;
        private System.Windows.Forms.CheckBox allowSpecialCharsCheckBox;
        private System.Windows.Forms.CheckBox allowUnderscoreCheckBox;
        private System.Windows.Forms.CheckBox allowSpaceCheckBox;
        private System.Windows.Forms.CheckBox allowOthersCheckBox;
        private System.Windows.Forms.CheckBox requireOthersCheckBox;
        private System.Windows.Forms.CheckBox requireSpaceCheckBox;
        private System.Windows.Forms.CheckBox requireUnderscoreCheckBox;
        private System.Windows.Forms.CheckBox requireSpecialCharsCheckBox;
        private System.Windows.Forms.CheckBox requireNumbersCheckBox;
        private System.Windows.Forms.CheckBox requireUppercaseCheckBox;
        private System.Windows.Forms.CheckBox requireLowercaseCheckBox;
        private System.Windows.Forms.Label minLengthLabel;
        private System.Windows.Forms.Label maxLengthLabel;
        private System.Windows.Forms.Label charactersLabel;
        private System.Windows.Forms.Label lowercaseLabel;
        private System.Windows.Forms.Label uppercaseLabel;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label specialLabel;
        private System.Windows.Forms.Label underscoreLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label otherCharsLabel;
        private System.Windows.Forms.TextBox otherCharsTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox minLengthTextBox;
        private System.Windows.Forms.TextBox maxLengthTextBox;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label seperatorLabel;
    }
}

