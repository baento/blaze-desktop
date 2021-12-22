using Core.Model;
using Flurl;
using Flurl.Http;

namespace Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void LoadBase()
        {
            dataGridView1.DataSource = await Core.UserProcessor.GetUsers(); 
            dataGridView2.DataSource = await Core.GroupProcessor.GetGroups();
        }

        private void ouvrirLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBase();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            listBox1.DataSource = ((Group)dataGridView2.Rows[e.RowIndex].DataBoundItem).Users;
        }
    }
}
