namespace PasswordKeeper
{
    partial class PasswordList
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
            this.passwordListView = new System.Windows.Forms.ListView();
            this.siteColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passwordColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordListView
            // 
            this.passwordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.siteColumn,
            this.passwordColumn});
            this.passwordListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.passwordListView.LabelWrap = false;
            this.passwordListView.Location = new System.Drawing.Point(0, 0);
            this.passwordListView.Name = "passwordListView";
            this.passwordListView.Size = new System.Drawing.Size(465, 201);
            this.passwordListView.TabIndex = 0;
            this.passwordListView.UseCompatibleStateImageBehavior = false;
            this.passwordListView.View = System.Windows.Forms.View.Details;
            // 
            // siteColumn
            // 
            this.siteColumn.Text = "Website";
            this.siteColumn.Width = 260;
            // 
            // passwordColumn
            // 
            this.passwordColumn.Text = "Password";
            this.passwordColumn.Width = 200;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(463, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 68);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(463, 67);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(88, 68);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(463, 134);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 68);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PasswordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 201);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordListView);
            this.MaximizeBox = false;
            this.Name = "PasswordList";
            this.Text = "Password List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView passwordListView;
        private System.Windows.Forms.ColumnHeader siteColumn;
        private System.Windows.Forms.ColumnHeader passwordColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}