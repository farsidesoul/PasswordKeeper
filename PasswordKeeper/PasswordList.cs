using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PasswordKeeper
{
    public partial class PasswordList : Form
    {
        // text file save location
        private const string FileLocation = @"H:\temp.txt";

        public PasswordList()
        {
            InitializeComponent();
            LoadListViewItems(FileLocation, passwordListView);
        }

        public static string site, pass;

        // Shows New Entry Form
        private void addButton_Click(object sender, EventArgs e)
        {
            NewEntryForm newItem = new NewEntryForm();
            newItem.ShowDialog();
            // Adds data from form
            AddItem();
        }

        private void AddItem()
        {
            ListViewItem lvi = passwordListView.Items.Add(site);
            lvi.SubItems.Add(pass);
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            SaveListViewItems(FileLocation, passwordListView);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteItems = MessageBox.Show(@"Are you sure you wish to delete the selected items?", @"Delete Selected?", MessageBoxButtons.YesNo);
            // If user doesn't wish to delete items, do nothing
            if (deleteItems != DialogResult.Yes)
            {
                //Do nothing and return.
            }
            else // delete all selected items.
            {
                foreach (ListViewItem eachItem in passwordListView.SelectedItems)
                {
                    passwordListView.Items.Remove(eachItem);
                }
            }
        }

        private static void SaveListViewItems(string path, ListView lv)
        {
            var delimeteredListViewData = new List<string>();

            foreach (ListViewItem lvi in lv.Items)
            {
                string delimeteredItems = string.Empty;
                foreach (ListViewItem.ListViewSubItem lvsi in lvi.SubItems)
                {
                    delimeteredItems += lvsi.Text + "#";
                }
                delimeteredListViewData.Add(delimeteredItems);
            }

            File.WriteAllLines(path, delimeteredListViewData.ToArray());
        }

        private static void LoadListViewItems(string path, ListView lv)
        {
            try
            {
                foreach (string line in File.ReadAllLines(path))
                {
                    lv.Items.Add(new ListViewItem(line.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries)));
                }
            }
            catch (FileNotFoundException)
            {
                // Don't worry about it.
            }
            
        }
    }
}
