namespace HomeAffairsDigitalIdentityProcessor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string idNumber = txtID.Text.Trim();
            string citizenship = comboCitizenship1.SelectedItem?.ToString() ?? "Unknown";

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            txtResults.Text = profile.ValidateID();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string idNumber = txtID.Text.Trim();
            string citizenship = comboCitizenship1.SelectedItem?.ToString() ?? "Unknown";

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            txtResults.Text = profile.GenerateProfileSummary();
        }
    }
}
