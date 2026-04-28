namespace Q3ProgrammingLanguagesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem != null)
            {
                string removed = lstLanguages.SelectedItem.ToString();
                lstLanguages.Items.Remove(lstLanguages.SelectedItem);
                lblStatus.Text = $"Removed '{removed}' at {DateTime.Now}";
            }
            else
            {
                lblStatus.Text = "No language selected to remove.";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            // Prevent empty input
            if (string.IsNullOrEmpty(language))
            {
                lblStatus.Text = "Cannot add empty input.";
                return;
            }

            // Prevent duplicates
            if (lstLanguages.Items.Contains(language))
            {
                lblStatus.Text = "Duplicate language not allowed.";
                return;
            }

            // Add language
            lstLanguages.Items.Add(language);
            lblStatus.Text = $"Added '{language}' at {DateTime.Now}";
            txtLanguage.Clear();
        }
    }
}
