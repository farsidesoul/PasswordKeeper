using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class NewEntryForm : Form
    {
        // Allows movement of boarderless window.
        protected override void OnLoad(EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
            {
                MouseDown += NewPasswordWindow_MouseDown;
                MouseMove += NewPasswordWindow_MouseMove;
                MouseUp += NewPasswordWindow_MouseUp;
            }
            base.OnLoad(e);
        }

        void NewPasswordWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            DownPoint = new Point(e.X, e.Y);
        }

        void NewPasswordWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (DownPoint == Point.Empty) return;
            Point location = new Point(Left + e.X - DownPoint.X, Top + e.Y - DownPoint.Y);
            Location = location;
        }

        void NewPasswordWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            DownPoint = Point.Empty;
        }

        public Point DownPoint = Point.Empty;
        // End window movement code.

        Random random = new Random();

        // Code based on code created by Sajjad Gull @CSharpens
        public NewEntryForm()
        {
            InitializeComponent();
        }

        public NewEntryForm(string site, string pass)
        {
            InitializeComponent();
            siteTextBox.Text = site;
            passwordTextBox.Text = pass;
        }

        private void allowLowerCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowLowercaseCheckBox.Checked) requireLowercaseCheckBox.Checked = false;
        }

        private void allowUppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowUppercaseCheckBox.Checked) requireUppercaseCheckBox.Checked = false;
        }

        private void allowNumbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowNumbersCheckBox.Checked) requireNumbersCheckBox.Checked = false;
        }

        private void allowSpecialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowSpecialCharsCheckBox.Checked) requireSpecialCharsCheckBox.Checked = false;
        }

        private void allowUnderscoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowUnderscoreCheckBox.Checked) requireUnderscoreCheckBox.Checked = false;
        }

        private void allowSpaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowSpaceCheckBox.Checked) requireSpaceCheckBox.Checked = false;
        }

        private void allowOthersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!allowOthersCheckBox.Checked) requireOthersCheckBox.Checked = false;
        }

        private void requireLowercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireLowercaseCheckBox.Checked) allowLowercaseCheckBox.Checked = true;
        }

        private void requireUppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireUppercaseCheckBox.Checked) allowUppercaseCheckBox.Checked = true;
        }

        private void requireNumbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireNumbersCheckBox.Checked) allowNumbersCheckBox.Checked = true;
        }

        private void requireSpecialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireSpecialCharsCheckBox.Checked) allowSpecialCharsCheckBox.Checked = true;
        }

        private void requireUnderscoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireUnderscoreCheckBox.Checked) allowUnderscoreCheckBox.Checked = true;
        }

        private void requireSpaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireSpaceCheckBox.Checked) allowSpaceCheckBox.Checked = true;
        }

        private void requireOthersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (requireOthersCheckBox.Checked) allowOthersCheckBox.Checked = true;
        }

        // Generate new Password
        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            try
            {
                passwordTextBox.Text = RandomPassword();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                noCharacterTypeSelectedError();
            }
        }

        // Generate a password that meets the checked requirements
        private string RandomPassword()
        {
            const string LOWER = "abcdefghijklmnopqrstuvwxyz";
            const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string NUMBERS = "0123456789";
            const string SPECIAL = @"~!@#$%^&*():;[]{}<>,.?/\|";
            string other = otherCharsTextBox.Text;
            if (requireOthersCheckBox.Checked && (other.Length < 1))
            {
                noCharacterTypeSelectedError();
                otherCharsTextBox.Focus();
                return passwordTextBox.Text;
            }

            // Make a list of allowed characters
            string allowed = "";
            if (allowLowercaseCheckBox.Checked) allowed += LOWER;
            if (allowUppercaseCheckBox.Checked) allowed += UPPER;
            if (allowNumbersCheckBox.Checked) allowed += NUMBERS;
            if (allowSpecialCharsCheckBox.Checked) allowed += SPECIAL;
            if (allowSpaceCheckBox.Checked) allowed += " ";
            if (allowUnderscoreCheckBox.Checked) allowed += "_";
            if (allowOthersCheckBox.Checked) allowed += other;

            // Pick the numbers of characters in the password
            int min_chars = 0;
            int max_chars = 0;
            try
            {
                min_chars = int.Parse(minLengthTextBox.Text);
            }
            catch (FormatException)
            {
                min_chars = 8;
            }
            try
            {
                max_chars = int.Parse(maxLengthTextBox.Text);
            }
            catch (FormatException)
            {
                max_chars = 16;
            }
            
            
            int passwordLength = random.Next(min_chars, max_chars);
            
            
            

            // Ensure the password satisfies requirements
            string password = "";
            if (requireLowercaseCheckBox.Checked && (password.IndexOfAny(LOWER.ToCharArray()) == -1))
                password += RandomChar(LOWER);
            if (requireUppercaseCheckBox.Checked && (password.IndexOfAny(UPPER.ToCharArray()) == -1))
                password += RandomChar(UPPER);
            if (requireNumbersCheckBox.Checked && (password.IndexOfAny(NUMBERS.ToCharArray()) == -1))
                password += RandomChar(NUMBERS);
            if (requireSpecialCharsCheckBox.Checked && (password.IndexOfAny(SPECIAL.ToCharArray()) == -1))
                password += RandomChar(SPECIAL);
            if (requireSpaceCheckBox.Checked && (password.IndexOfAny(" ".ToCharArray()) == -1))
                password += " ";
            if (requireUnderscoreCheckBox.Checked && (password.IndexOfAny("_".ToCharArray()) == -1))
                password += "_";
            if (requireOthersCheckBox.Checked && (password.IndexOfAny(other.ToCharArray()) == -1))
                password += RandomChar(other);

            // Add the remaining characters randomly
            try
            {
                while (password.Length < passwordLength)
                    password += allowed.Substring(random.Next(0, allowed.Length - 1), 1);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error. You must select at least on type of character for your password.");
            }

            // Randomise (to mix the required characters from front of string)
            password = RandomiseString(password);

            return password;

        }

        // Return a random character from a string
        private string RandomChar(string str)
        {
            return str.Substring(random.Next(0, str.Length - 1), 1);
        }

        // Return a random permutation of a string
        private string RandomiseString(string str)
        {
            string result = "";
            while (str.Length > 0)
            {
                // Pick a random character.
                int i = random.Next(0, str.Length - 1);
                result += str.Substring(i, 1);
                str = str.Remove(i, 1);
            }
            return result;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            PasswordList.site = siteTextBox.Text;
            PasswordList.pass = passwordTextBox.Text;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void noCharacterTypeSelectedError()
        {
            MessageBox.Show("You must specify at least one type of character to be used.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }
        

    }
}
