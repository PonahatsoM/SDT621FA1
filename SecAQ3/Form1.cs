using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SecAQ3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, DateTime> languages = new Dictionary<string, DateTime>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lang = txtLanguage.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrEmpty(lang))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            // Prevent duplicates
            if (languages.ContainsKey(lang))
            {
                MessageBox.Show("This language is already in the list.");
                return;
            }

            // Add language with timestamp
            languages[lang] = DateTime.Now;
            RefreshList();
            txtLanguage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBoxLanguages.SelectedItem != null)
            {
                // Extract the language name before the dash
                string selected = listBoxLanguages.SelectedItem.ToString().Split('-')[0].Trim();
                languages.Remove(selected);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Please select a language to remove.");
            }
        }
        private void RefreshList()
        {
            listBoxLanguages.Items.Clear();
            foreach (var entry in languages)
            {
                listBoxLanguages.Items.Add($"{entry.Key} - Added on {entry.Value}");
            }
        }

        // Optional: handle selection change
        private void listBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Logic if needed when user selects an item
        }

        // Optional: handle text change in txtLanguage
        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {
        }

    }
}