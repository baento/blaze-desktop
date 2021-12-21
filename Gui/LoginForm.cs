using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core;
using Core.Model;

namespace Gui
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;

            try
            {
                HttpContent content = new FormUrlEncodedContent(new[] {
                    new KeyValuePair<string, string>("username", usernameTextBox.Text),
                    new KeyValuePair<string, string>("password", passwordTextBox.Text),
                });

                using (HttpResponseMessage response = await API.APIClient.PostAsync("/login", content))
                {
                    if (response.IsSuccessStatusCode) //Successful login
                    {
                        User user = await response.Content.ReadAsAsync<User>();
                        this.Close();
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK);
            }

            connectButton.Enabled = true;
        }
    }
}
