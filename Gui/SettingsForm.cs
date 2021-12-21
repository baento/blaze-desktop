using Core.Properties;

namespace Gui
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Save()
        {
            Settings.Default.ApiUrl = this.textBox1.Text;
            Settings.Default.ApiKey = this.textBox2.Text;
            Settings.Default.AutoUpdate = this.autoUpdateCheckbox.Checked;
            Settings.Default.Save();
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
            enregistrerToolStripButton.Enabled = false;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Settings.Default.ApiUrl;
            textBox2.Text = Settings.Default.ApiKey;
            autoUpdateCheckbox.Checked = Settings.Default.AutoUpdate;

            lastUpdateLabel.Text = Settings.Default.LastUpdate.ToString();
            lastUpdatePollLabel.Text = Settings.Default.LastUpdatePoll.ToString();
        }

        private bool Changed()
        {
            return textBox1.Text != Settings.Default.ApiUrl
                || textBox2.Text != Settings.Default.ApiKey
                || autoUpdateCheckbox.Checked != Settings.Default.AutoUpdate;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Changed())
            {
                DialogResult dialogResult = MessageBox.Show(this, "Voulez-vous sauvegarder vos changements ?", "Paramètres", MessageBoxButtons.YesNoCancel);
                
                if (dialogResult == DialogResult.Yes)
                {
                    Save();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enregistrerToolStripButton.Enabled = Changed();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            enregistrerToolStripButton.Enabled = Changed();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            enregistrerToolStripButton.Enabled = Changed();
        }

        private void pollUpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private async void testAPIButton_Click(object sender, EventArgs e)
        {
            try
            {
                Version version = await Core.VersionProcessor.GetVersion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
