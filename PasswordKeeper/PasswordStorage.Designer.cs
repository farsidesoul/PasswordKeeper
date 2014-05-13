using System.Windows.Forms;

namespace PasswordKeeper
{
    partial class PasswordStorageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordGrid = new System.Windows.Forms.DataGridView();
            this.siteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            this.newPassword = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // passwordGrid
            // 
            this.passwordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteName,
            this.password,
            this.lastChanged,
            this.copyPassword,
            this.newPassword});
            this.passwordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGrid.Location = new System.Drawing.Point(0, 0);
            this.passwordGrid.Name = "passwordGrid";
            this.passwordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.passwordGrid.Size = new System.Drawing.Size(775, 333);
            this.passwordGrid.TabIndex = 3;
            this.passwordGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordGrid_CellContentClick);
            // 
            // siteName
            // 
            this.siteName.FillWeight = 200F;
            this.siteName.HeaderText = "Site Name";
            this.siteName.Name = "siteName";
            this.siteName.ReadOnly = true;
            this.siteName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.siteName.Width = 200;
            // 
            // password
            // 
            this.password.FillWeight = 200F;
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.password.Width = 200;
            // 
            // lastChanged
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lastChanged.DefaultCellStyle = dataGridViewCellStyle1;
            this.lastChanged.FillWeight = 200F;
            this.lastChanged.HeaderText = "Last Date Changed";
            this.lastChanged.Name = "lastChanged";
            this.lastChanged.ReadOnly = true;
            this.lastChanged.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastChanged.Width = 200;
            // 
            // copyPassword
            // 
            this.copyPassword.HeaderText = "Copy Password";
            this.copyPassword.Name = "copyPassword";
            this.copyPassword.ReadOnly = true;
            this.copyPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.copyPassword.Width = 65;
            // 
            // newPassword
            // 
            this.newPassword.HeaderText = "New Password";
            this.newPassword.Name = "newPassword";
            this.newPassword.ReadOnly = true;
            this.newPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.newPassword.Width = 65;
            // 
            // PasswordStorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(775, 333);
            this.Controls.Add(this.passwordGrid);
            this.Controls.Add(this.label1);
            this.Name = "PasswordStorageForm";
            this.Text = "Password Storage Box";
            ((System.ComponentModel.ISupportInitialize)(this.passwordGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView passwordGrid;
        private DataGridViewTextBoxColumn siteName;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn lastChanged;
        private DataGridViewButtonColumn copyPassword;
        private DataGridViewButtonColumn newPassword;
    }
}