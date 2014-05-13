using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class PasswordStorageForm : Form
    {
        public PasswordStorageForm()
        {
            InitializeComponent();
        }

        public PasswordStorageForm(string website, string password)
        {

        }

        private void passwordGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) // Copy button in DataGridView
            {
                Clipboard.SetDataObject(passwordGrid.CurrentCell.Value.ToString(), false);
            }
            if (e.ColumnIndex == 4) // New/Edit button in DataGridView
            {
                NewEntryForm newEntry = new NewEntryForm();
                newEntry.Show();
            }
        }

    }
}
