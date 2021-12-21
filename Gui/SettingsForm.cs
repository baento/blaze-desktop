using Core.Properties;
using Version = Core.Model.Version;
using System.Net.Http.Headers;
using Core;

namespace Gui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        private void APISettingsForm_Load(object sender, EventArgs e)
        {
            baseUriTextBox.Text = Settings.Default.ApiBaseUri;
            keyTextBox.Text = Settings.Default.ApiKey;
        }

        private async void apiTestButton_Click(object sender, EventArgs e)
        {
            testButton.Enabled = false;
            saveButton.Enabled = false;

            try
            {
                HttpClient testClient = new HttpClient();
                testClient.BaseAddress = new Uri(baseUriTextBox.Text);
                testClient.DefaultRequestHeaders.Accept.Clear();
                testClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await testClient.GetAsync("version"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        Version version = await response.Content.ReadAsAsync<Version>();
                        apiTestLabel.Image = Properties.Resources.Checkmark;
                        apiTestLabel.Text = $"Version {version.major}.{version.minor}.{version.patch}";
                    }
                    else
                    {
                        throw new Exception(response.StatusCode.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Serveur inaccessible : {ex.Message}", "Connexion échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                apiTestLabel.Image = Properties.Resources.Close;
                apiTestLabel.Text = "";
            }

            testButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.ApiBaseUri = baseUriTextBox.Text;
            Settings.Default.ApiKey = keyTextBox.Text;
            Settings.Default.Save();

            API.Initialize();

            saveButton.Enabled = false;
        }

        private bool Changed()
        {
            return (Uri.IsWellFormedUriString(baseUriTextBox.Text, UriKind.Absolute)
                && baseUriTextBox.Text != Settings.Default.ApiBaseUri)
                || keyTextBox.Text != Settings.Default.ApiKey;
        }

        private void ValidateUri()
        {
            if (Uri.IsWellFormedUriString(baseUriTextBox.Text, UriKind.Absolute))
            {
                errorProvider.SetError(baseUriTextBox, "");
                testButton.Enabled = true;
                saveButton.Enabled = Changed();
            }
            else
            {
                errorProvider.SetError(baseUriTextBox, "Addresse mal formée");
                errorProvider.SetIconPadding(baseUriTextBox, 6);
                testButton.Enabled = false;
                saveButton.Enabled = false;
            }
        }

        private void uriTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateUri();
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ValidateUri();
        }
    }
}
